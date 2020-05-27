namespace KubernetesClient.Simple.Models.Pods
{
    public class AzureDiskVolumeSource
    {
        public string CachingMode { get; set; }
        public string DiskName { get; set; }
        public string DiskURI { get; set; }
        public string FsType { get; set; }
        public string Kind { get; set; }
        public bool? ReadOnly { get; set; }
    }
}
