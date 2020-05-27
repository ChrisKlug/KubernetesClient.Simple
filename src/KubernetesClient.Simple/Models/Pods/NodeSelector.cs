using System.Collections.Generic;

namespace KubernetesClient.Simple.Models.Pods
{
    public class NodeSelector
    {
        public IList<NodeSelectorTerm> NodeSelectorTerms { get; set; }
    }
}
