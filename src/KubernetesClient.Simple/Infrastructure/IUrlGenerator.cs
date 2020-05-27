using System;

namespace KubernetesClient.Simple.Infrastructure
{
    public interface IUrlGenerator
    {
        Uri GetUri(IKubernetesResourceDefinition resourceDefinition, string @namespace = null, string name = null);
    }
}
