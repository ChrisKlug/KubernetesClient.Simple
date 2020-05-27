namespace KubernetesClient.Simple.Models.Pods
{
    public class TCPSocketAction
    {
        public string Host { get; set; }
        public k8s.Models.IntstrIntOrString Port { get; set; }
    }
}
