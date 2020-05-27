namespace KubernetesClient.Simple.Models.Pods
{
    public class CinderVolumeSource
    {
        public string FsType { get; set; }
        public bool? ReadOnly { get; set; }
        public LocalObjectReference SecretRef { get; set; }
        public string VolumeID { get; set; }
    }
}
