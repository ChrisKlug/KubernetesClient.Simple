namespace KubernetesClient.Simple.Models.Pods
{
    public class DownwardAPIVolumeFile
    {
        public ObjectFieldSelector FieldRef { get; set; }
        public int? Mode { get; set; }
        public string Path { get; set; }
        public ResourceFieldSelector ResourceFieldRef { get; set; }
    }
}
