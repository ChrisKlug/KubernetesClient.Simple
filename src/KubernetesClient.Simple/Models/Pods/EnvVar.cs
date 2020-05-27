namespace KubernetesClient.Simple.Models.Pods
{
    public class EnvVar
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public EnvVarSource ValueFrom { get; set; }
    }
}
