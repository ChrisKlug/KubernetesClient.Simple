namespace KubernetesClient.Simple.Models.Pods
{
    public class Affinity
    {
        public NodeAffinity NodeAffinity { get; set; }
        public PodAffinity PodAffinity { get; set; }
        public PodAntiAffinity PodAntiAffinity { get; set; }
    }
}
