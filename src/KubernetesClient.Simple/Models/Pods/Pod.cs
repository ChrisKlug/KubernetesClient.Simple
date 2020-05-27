namespace KubernetesClient.Simple.Models.Pods
{
    public abstract class Pod
    {
        public string ApiVersion { get; set; }
        public string Kind { get; set; }
        public ObjectMeta Metadata { get; set; }
        public PodSpec Spec { get; set; }
        public PodStatus Status { get; set; }
    }
}
