namespace KubernetesClient.Simple.Models.Pods
{
    public class Probe
    {
        public ExecAction Exec { get; set; }
        public int? FailureThreshold { get; set; }
        public HTTPGetAction HttpGet { get; set; }
        public int? InitialDelaySeconds { get; set; }
        public int? PeriodSeconds { get; set; }
        public int? SuccessThreshold { get; set; }
        public TCPSocketAction TcpSocket { get; set; }
        public int? TimeoutSeconds { get; set; }
    }
}
