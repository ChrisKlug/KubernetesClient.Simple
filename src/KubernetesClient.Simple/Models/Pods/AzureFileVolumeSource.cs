namespace KubernetesClient.Simple.Models.Pods
{
    public class AzureFileVolumeSource
    {
        public bool? ReadOnly { get; set; }
        public string SecretName { get; set; }
        public string ShareName { get; set; }
    }
}
