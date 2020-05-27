using System.Collections.Generic;

namespace KubernetesClient.Simple.Models.Pods
{
    public class Capabilities
    {
        public IList<string> Add { get; set; }
        public IList<string> Drop { get; set; }
    }
}
