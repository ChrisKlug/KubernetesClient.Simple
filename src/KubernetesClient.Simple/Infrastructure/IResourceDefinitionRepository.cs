using System;

namespace KubernetesClient.Simple.Infrastructure
{
    public interface IResourceDefinitionRepository
    {
        IKubernetesResourceDefinition GetDefinition(Type resourceType);
    }
}
