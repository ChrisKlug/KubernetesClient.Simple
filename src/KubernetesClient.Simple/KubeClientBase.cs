using KubernetesClient.Simple.Exceptions;
using KubernetesClient.Simple.Infrastructure;
using KubernetesClient.Simple.Models;
using Microsoft.AspNetCore.JsonPatch;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace KubernetesClient.Simple
{
    public abstract class KubeClientBase : IKubeClient
    {
        private readonly IUrlGenerator UrlGenerator;
        protected readonly IHttpClientAccessor HttpClientAccessor;
        protected readonly IRequestCredentialsProvider RequestCredentialsProvider;
        protected readonly IResourceDefinitionRepository ResourceDefinitionRepository;

        protected KubeClientBase(IUrlGenerator urlGenerator, 
                                IHttpClientAccessor httpClientAccessor, 
                                IRequestCredentialsProvider requestCredentialsProvider, 
                                IResourceDefinitionRepository resourceDefinitionRepository)
        {
            UrlGenerator = urlGenerator;
            HttpClientAccessor = httpClientAccessor;
            RequestCredentialsProvider = requestCredentialsProvider;
            ResourceDefinitionRepository = resourceDefinitionRepository;
        }

        public async Task<T> Get<T>(string name)
        {
            var resourceDefinition = GetResourceDefinition<T>(ResourceScope.Cluster);
            var req = new RequestSpec(HttpMethod.Get, resourceDefinition) { Name = name };
            var response = await MakeRequest(req, CancellationToken.None);
            if (response.HttpStatusCode != HttpStatusCode.OK)
            {
                return default;
            }

            return JsonConvert.DeserializeObject<T>(response.Content);
        }
        public async Task<T> Get<T>(string @namespace, string name)
        {
            var resourceDefinition = GetResourceDefinition<T>(ResourceScope.Namespace);
            var req = new RequestSpec(HttpMethod.Get, resourceDefinition) { Namespace = @namespace, Name = name };
            var response = await MakeRequest(req, CancellationToken.None);
            if (response.HttpStatusCode != HttpStatusCode.OK)
            {
                return default;
            }

            return JsonConvert.DeserializeObject<T>(response.Content);
        }

        public async Task<(IEnumerable<T> Items, string ContinuationToken)> List<T>(string @namespace = null, string continuationToken = null)
        {
            var list = await ListRaw<T>(@namespace, continuationToken);
            return list != null ? ( list.Items, ContinuationToken: list.Metadata.ContinueProperty) : default;
        }
        public async Task<ResourceList<T>> ListRaw<T>(string @namespace = null, string continuationToken = null)
        {
            var resourceDefinition = ResourceDefinitionRepository.GetDefinition(typeof(T));
            var req = new RequestSpec(HttpMethod.Get, resourceDefinition) { Namespace = @namespace };

            if (!string.IsNullOrWhiteSpace(continuationToken))
            {
                req.QueryParams.Add("continue", continuationToken);
            }

            var response = await MakeRequest(req, CancellationToken.None);
            if (response.HttpStatusCode != HttpStatusCode.OK)
            {
                return null;
            }

            return JsonConvert.DeserializeObject<ResourceList<T>>(response.Content);
        }
        public Task<T> Patch<T>(T resource, Action<T, JsonPatchDocument<T>> patchAction) where T: class
        {
            var patch = new JsonPatchDocument<T>();
            patchAction(resource, patch);
            patch.Operations.ForEach(x => x.path = x.path.ToLower());

            //TODO: Send Patch to server
            // var response = await _kubernetes.PatchNamespacedCustomObjectAsync(new V1Patch(patch), Foo.Group, Foo.Version, "default", Foo.Plural, foo.Metadata.Name);

            return resource;
        }

        protected virtual IKubernetesResourceDefinition GetResourceDefinition<T>(ResourceScope expectedScope)
        {
            var resourceDefinition = ResourceDefinitionRepository.GetDefinition(typeof(T));
            if (resourceDefinition.Scope != expectedScope)
            {
                var message = expectedScope == ResourceScope.Cluster ? 
                                                "Cannot get a namespaced resource without a namespace" :
                                                "Cannot get a non-namespaced resource through a namespace";
                throw new InvalidScopeException(message);

            }
            return resourceDefinition;
        }
        protected abstract void EnsureResourceDefinitionSupport(IKubernetesResourceDefinition resourceDefinition);

        protected async Task<(HttpStatusCode HttpStatusCode, string Content)> MakeRequest(RequestSpec req, CancellationToken cancellationToken)
        {
            EnsureResourceDefinitionSupport(req.ResourceDefinition);

            var uri = UrlGenerator.GetUri(req.ResourceDefinition, req.Namespace, req.Name, req.QueryParams);

            var httpRequest = new HttpRequestMessage(req.Method, uri);

            cancellationToken.ThrowIfCancellationRequested();
            await RequestCredentialsProvider.ProcessHttpRequestMessage(httpRequest);

            cancellationToken.ThrowIfCancellationRequested();
            var httpResponse = await HttpClientAccessor.GetHttpClient().SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            var statusCode = httpResponse.StatusCode;

            cancellationToken.ThrowIfCancellationRequested();
            var content = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);

            httpRequest.Dispose();
            httpResponse.Dispose();

            return (HttpStatusCode: statusCode, Content: content);
        }

        protected class RequestSpec 
        {
            public RequestSpec(HttpMethod method, IKubernetesResourceDefinition resourceDefinition)
            {
                Method = method;
                ResourceDefinition = resourceDefinition;
            }

            public HttpMethod Method { get; }
            public IKubernetesResourceDefinition ResourceDefinition { get; }
            public string Namespace { get; set; }
            public string Name { get; set; }
            public Dictionary<string, string> QueryParams { get; set; } = new Dictionary<string, string>();
        }
    }
}
