using System;
using System.Collections.Generic;

namespace KubernetesClient.Simple.Infrastructure
{
    public interface IUrlGenerator
    {
        Uri GetUri(IKubernetesResourceDefinition resourceDefinition, string @namespace = null, string name = null, IDictionary<string, string> queryParams = null);
    }
}
