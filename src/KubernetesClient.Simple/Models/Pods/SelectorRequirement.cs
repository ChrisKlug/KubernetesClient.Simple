using System.Collections.Generic;

namespace KubernetesClient.Simple.Models.Pods
{
    public class SelectorRequirement
    {
        public string Key { get; set; }
        public string Operator { get; set; }
        public IList<string> Values { get; set; }
    }
}
