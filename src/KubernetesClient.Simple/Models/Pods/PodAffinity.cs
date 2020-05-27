using System.Collections.Generic;

namespace KubernetesClient.Simple.Models.Pods
{
    public class PodAffinity
    {
        public IList<WeightedPodAffinityTerm> PreferredDuringSchedulingIgnoredDuringExecution { get; set; }
    }
}
