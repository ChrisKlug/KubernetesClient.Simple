namespace KubernetesClient.Simple.Models.Pods
{
    public class WeightedPodAffinityTerm
    {
        public PodAffinityTerm PodAffinityTerm { get; set; }
        public int Weight { get; set; }
    }
}
