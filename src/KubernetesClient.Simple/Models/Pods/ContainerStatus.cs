namespace KubernetesClient.Simple.Models.Pods
{
    public class ContainerStatus
    {
        public string ContainerID { get; set; }
        public string Image { get; set; }
        public string ImageID { get; set; }
        public ContainerState LastState { get; set; }
        public string Name { get; set; }
        public bool Ready { get; set; }
        public int RestartCount { get; set; }
        public bool? Started { get; set; }
        public ContainerState State { get; set; }
    }
}
