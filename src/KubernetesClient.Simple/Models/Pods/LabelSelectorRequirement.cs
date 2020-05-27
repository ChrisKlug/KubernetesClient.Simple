using System.Collections.Generic;

namespace KubernetesClient.Simple.Models.Pods
{
    public class LabelSelectorRequirement
    {
        public string Key { get; set; }
        public string OperatorProperty { get; set; }
        public IList<string> Values { get; set; }
    }
}
