namespace KubernetesClient.Simple.Models
{
    public class OwnerReference
    {
        public string ApiVersion { get; set; }
        public bool? BlockOwnerDeletion { get; set; }
        public bool? Controller { get; set; }
        public string Kind { get; set; }
        public string Name { get; set; }
        public string Uid { get; set; }
    }
}
