namespace KubernetesClient.Simple.Models.Pods
{
    public class SecretKeySelector
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public bool? Optional { get; set; }
    }
}
