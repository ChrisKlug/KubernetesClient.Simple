using KubernetesClient.Simple.Infrastructure;
using KubernetesClient.Simple.Models;
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

        protected KubeClientBase(IUrlGenerator urlGenerator, IHttpClientAccessor httpClientAccessor, 
                                IRequestCredentialsProvider requestCredentialsProvider, IResourceDefinitionRepository resourceDefinitionRepository)
        {
            UrlGenerator = urlGenerator;
            HttpClientAccessor = httpClientAccessor;
            RequestCredentialsProvider = requestCredentialsProvider;
            ResourceDefinitionRepository = resourceDefinitionRepository;
        }

        public Task<T> Get<T>(string name)
        {
            throw new NotImplementedException();
        }
        public async Task<T> Get<T>(string @namespace, string name)
        {
            var resourceDefinition = ResourceDefinitionRepository.GetDefinition(typeof(T));
            var response = await MakeRequest(HttpMethod.Get, resourceDefinition, @namespace, name, CancellationToken.None);
            if (response.HttpStatusCode != HttpStatusCode.OK)
            {
                return default;
            }

            return JsonConvert.DeserializeObject<T>(response.Content);
        }
        public Task<IEnumerable<T>> ListAll<T>()
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<T>> List<T>(string @namespace)
        {
            var list = await ListRaw<T>(@namespace);
            return list != null ? list.Items : null;
        }
        public Task<ResourceList<T>> ListRaw<T>()
        {
            throw new NotImplementedException();
        }
        public async Task<ResourceList<T>> ListRaw<T>(string @namespace)
        {
            var resourceDefinition = ResourceDefinitionRepository.GetDefinition(typeof(T));
            var response = await MakeRequest(HttpMethod.Get, resourceDefinition, @namespace, null, CancellationToken.None);
            if (response.HttpStatusCode != HttpStatusCode.OK)
            {
                return null;
            }

            return JsonConvert.DeserializeObject<ResourceList<T>>(response.Content);
        }

        protected async Task<(HttpStatusCode HttpStatusCode, string Content)> MakeRequest(HttpMethod method, IKubernetesResourceDefinition resourceDefinition, string @namespace, string name, CancellationToken cancellationToken)
        {
            var uri = UrlGenerator.GetUri(resourceDefinition, @namespace, name);

            var httpRequest = new HttpRequestMessage(method, uri);

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
    }
}
