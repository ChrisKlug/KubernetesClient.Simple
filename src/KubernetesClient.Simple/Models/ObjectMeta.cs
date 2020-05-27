using System;
using System.Collections.Generic;

namespace KubernetesClient.Simple.Models
{
    public class ObjectMeta
    {
        public string ResourceVersion { get; set; }
        public IList<OwnerReference> OwnerReferences { get; set; }
        public string NamespaceProperty { get; set; }
        public string Name { get; set; }
        public IList<ManagedFieldsEntry> ManagedFields { get; set; }
        public IDictionary<string, string> Labels { get; set; }
        public long? Generation { get; set; }
        public string GenerateName { get; set; }
        public IList<string> Finalizers { get; set; }
        public DateTime? DeletionTimestamp { get; set; }
        public long? DeletionGracePeriodSeconds { get; set; }
        public DateTime? CreationTimestamp { get; set; }
        public string ClusterName { get; set; }
        public IDictionary<string, string> Annotations { get; set; }
        public string SelfLink { get; set; }
        public string Uid { get; set; }
    }
}
