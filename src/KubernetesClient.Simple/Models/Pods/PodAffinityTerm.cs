using System.Collections.Generic;

namespace KubernetesClient.Simple.Models.Pods
{
    public class PodAffinityTerm
    {
        public LabelSelector LabelSelector { get; set; }
        public IList<string> Namespaces { get; set; }
        public string TopologyKey { get; set; }
    }
}
