using System.Collections.Generic;

namespace KubernetesClient.Simple.Models.Pods
{
    public class NodeSelectorTerm
    {
        public IList<NodeSelectorRequirement> MatchExpressions { get; set; }
        public IList<NodeSelectorRequirement> MatchFields { get; set; }
    }
}
