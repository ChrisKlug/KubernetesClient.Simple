namespace KubernetesClient.Simple.Models.Pods
{
    public class PreferredSchedulingTerm
    {
        public NodeSelectorTerm Preference { get; set; }
        public int Weight { get; set; }
    }
}
