namespace KubernetesClient.Simple.Models.Pods
{
    public class TopologySpreadConstraint
    {
        public LabelSelector LabelSelector { get; set; }
        public int MaxSkew { get; set; }
        public string TopologyKey { get; set; }
        public string WhenUnsatisfiable { get; set; }
    }
}
