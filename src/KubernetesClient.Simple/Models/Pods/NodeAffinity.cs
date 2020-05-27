using System.Collections.Generic;

namespace KubernetesClient.Simple.Models.Pods
{
    public class NodeAffinity
    {
        public IList<PreferredSchedulingTerm> PreferredDuringSchedulingIgnoredDuringExecution { get; set; }
        public NodeSelector RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
    }
}
