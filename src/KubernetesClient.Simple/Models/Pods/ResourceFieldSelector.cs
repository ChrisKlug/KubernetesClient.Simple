using k8s.Models;

namespace KubernetesClient.Simple.Models.Pods
{
    public class ResourceFieldSelector
    {
        public string ContainerName { get; set; }
        public ResourceQuantity Divisor { get; set; }
        public string Resource { get; set; }
    }
}
