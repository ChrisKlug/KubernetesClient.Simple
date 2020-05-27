using System.Collections.Generic;

namespace KubernetesClient.Simple.Models.Pods
{
    public class HostAlias
    {
        public IList<string> Hostnames { get; set; }
        public string Ip { get; set; }
    }
}
