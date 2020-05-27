using System.Collections.Generic;

namespace KubernetesClient.Simple.Models.Pods
{
    public class ResourceRequirements
    {
        public IDictionary<string, ResourceQuantity> Limits { get; set; }
        public IDictionary<string, ResourceQuantity> Requests { get; set; }
    }
}
