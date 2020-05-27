using System.Collections.Generic;

namespace KubernetesClient.Simple.Models.Pods
{
    public class NodeSelectorTerm
    {
        public IList<SelectorRequirement> MatchExpressions { get; set; }
        public IList<SelectorRequirement> MatchFields { get; set; }
    }
}
