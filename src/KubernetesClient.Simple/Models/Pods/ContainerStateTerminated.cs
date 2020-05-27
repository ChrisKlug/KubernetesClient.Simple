namespace KubernetesClient.Simple.Models.Pods
{
    public class ContainerStateTerminated
    {
        public string ContainerID { get; set; }
        public int ExitCode { get; set; }
        public System.DateTime? FinishedAt { get; set; }
        public string Message { get; set; }
        public string Reason { get; set; }
        public int? Signal { get; set; }
        public System.DateTime? StartedAt { get; set; }
    }
}
