using System;

namespace KubernetesClient.Simple.Infrastructure
{
    public class DefaultUrlGenerator : IUrlGenerator
    {
        private readonly Uri _baseUri;

        public DefaultUrlGenerator(Uri baseUri)
        {
            var baseUrl = baseUri.AbsoluteUri.TrimEnd('/');
            _baseUri = new Uri(baseUrl);
        }

        public Uri GetUri(IKubernetesResourceDefinition resourceDefinition, string @namespace = null, string name = null)
        {
            @namespace = @namespace == null ? "" : "/namespaces/" + @namespace;
            name = name == null ? "" : "/" + name;

            return new Uri(
                _baseUri,
                $"{(resourceDefinition.Group == "core" ? "api" : "apis/" + resourceDefinition.Group)}/{resourceDefinition.ApiVersion}{@namespace}/{resourceDefinition.Plural}{name}"
            );
        }
    }
}
