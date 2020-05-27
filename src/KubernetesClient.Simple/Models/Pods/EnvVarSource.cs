namespace KubernetesClient.Simple.Models.Pods
{
    public class EnvVarSource
    {
        public ConfigMapKeySelector ConfigMapKeyRef { get; set; }
        public ObjectFieldSelector FieldRef { get; set; }
        public ResourceFieldSelector ResourceFieldRef { get; set; }
        public SecretKeySelector SecretKeyRef { get; set; }
    }
}
