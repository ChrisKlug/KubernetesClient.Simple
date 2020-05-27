using System.Collections.Generic;

namespace KubernetesClient.Simple.Models.Pods
{
    public class PodDNSConfig
    {
        public IList<string> Nameservers { get; set; }
        public IList<PodDNSConfigOption> Options { get; set; }
        public IList<string> Searches { get; set; }
    }
}
