using System;
using System.Collections.Generic;
using System.Linq;

namespace KubernetesClient.Simple.Infrastructure
{
    public class ResourceDefinitionRepository : IResourceDefinitionRepository
    {
        private readonly Dictionary<Type, KubernetesResourceAttribute> _resources = new Dictionary<Type, KubernetesResourceAttribute>();

        public ResourceDefinitionRepository()
        {
            //_resources.Add(typeof(V1Service), new KubernetesResourceAttribute("Service", "core", "v1", "services", "service", ResourceScope.Namespace, ));
            //_resources.Add(typeof(V1Pod), new ResourceDefinition("Pod", "core", "v1", "pods", "pod", ResourceScope.Namespace));
        }

        public IKubernetesResourceDefinition GetDefinition(Type resourceType)
        {
            KubernetesResourceAttribute definition;

            if (_resources.TryGetValue(resourceType, out definition)) 
            {
                return definition;
            }

            definition = (KubernetesResourceAttribute)resourceType.GetCustomAttributes(typeof(KubernetesResourceAttribute), true).FirstOrDefault();
            if (definition == null)
            {
                throw new Exception("Cannot locate a KubernetesResourceAttribute on " + resourceType.Name);
            }

            _resources.Add(resourceType, definition);

            return definition;
        }
    }
}
