using System.Collections.Generic;

namespace KubernetesClient.Simple.Models.Pods
{
    public class HTTPGetAction
    {
        public string Host { get; set; }
        public IList<HTTPHeader> HttpHeaders { get; set; }
        public string Path { get; set; }
        public k8s.Models.IntstrIntOrString Port { get; set; }
        public string Scheme { get; set; }
    }
}
