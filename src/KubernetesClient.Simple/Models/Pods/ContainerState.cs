namespace KubernetesClient.Simple.Models.Pods
{
    public class ContainerState
    {
        public ContainerStateRunning Running { get; set; }
        public ContainerStateTerminated Terminated { get; set; }
        public ContainerStateWaiting Waiting { get; set; }
    }
}
