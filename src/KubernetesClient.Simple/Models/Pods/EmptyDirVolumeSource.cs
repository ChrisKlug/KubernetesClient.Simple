using k8s.Models;

namespace KubernetesClient.Simple.Models.Pods
{
    public class EmptyDirVolumeSource
    {
        public string Medium { get; set; }
        public ResourceQuantity SizeLimit { get; set; }
    }
}
