namespace KubernetesClient.Simple.Models.Pods
{
    public class PodCondition
    {
        public System.DateTime? LastProbeTime { get; set; }
        public System.DateTime? LastTransitionTime { get; set; }
        public string Message { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
    }
}
