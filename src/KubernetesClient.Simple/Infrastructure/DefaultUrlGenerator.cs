using System;
using System.Collections.Generic;
using System.Linq;

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

        public Uri GetUri(IKubernetesResourceDefinition resourceDefinition, string @namespace = null, string name = null, IDictionary<string, string> queryParams = null)
        {
            @namespace = @namespace == null ? "" : "/namespaces/" + @namespace;
            name = name == null ? "" : "/" + name;

            var querystring = "";
            if (queryParams != null && queryParams.Any())
            {
                foreach (var item in queryParams)
                {
                    querystring += $"{item.Key}={Uri.EscapeDataString(item.Value)}&";
                }
                querystring = "?" + querystring.TrimEnd('&');
            }

            return new Uri(
                _baseUri,
                $"{(resourceDefinition.Group == "core" ? "api" : "apis/" + resourceDefinition.Group)}/{resourceDefinition.ApiVersion}{@namespace}/{resourceDefinition.Plural}{name}{querystring}"
            );
        }
    }
}
