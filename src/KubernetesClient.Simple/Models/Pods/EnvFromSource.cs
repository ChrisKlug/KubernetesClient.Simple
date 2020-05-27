namespace KubernetesClient.Simple.Models.Pods
{
    public class EnvFromSource
    {
        public EnvSource ConfigMapRef { get; set; }
        public string Prefix { get; set; }
        public EnvSource SecretRef { get; set; }
    }
}
