namespace KubernetesClient.Simple.Models.Pods
{
    public class Lifecycle
    {
        public Handler PostStart { get; set; }
        public Handler PreStop { get; set; }
    }
}
