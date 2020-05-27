using k8s.Models;
using System.Collections.Generic;

namespace KubernetesClient.Simple.Models
{
    public class ResourceList<T>
    {
        public string ApiVersion { get; set; }
        public string Kind { get; set; }
        public V1ListMeta Metadata { get; set; }
        public IList<T> Items { get; set; }
    }
}
