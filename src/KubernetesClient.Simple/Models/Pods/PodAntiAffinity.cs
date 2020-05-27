using System.Collections.Generic;

namespace KubernetesClient.Simple.Models.Pods
{
    public class PodAntiAffinity
    {
        public IList<WeightedPodAffinityTerm> PreferredDuringSchedulingIgnoredDuringExecution { get; set; }
        public IList<PodAffinityTerm> RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
    }
}
