using System.Collections.Generic;

namespace KubernetesClient.Simple.Models.Pods
{
    public class NodeSelectorRequirement
    {
        public string Key { get; set; }
        public string OperatorProperty { get; set; }
        public IList<string> Values { get; set; }
    }
}
