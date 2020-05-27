namespace KubernetesClient.Simple.Models.Pods
{
    public class Handler
    {
        public ExecAction Exec { get; set; }
        public HTTPGetAction HttpGet { get; set; }
        public TCPSocketAction TcpSocket { get; set; }
    }
}
