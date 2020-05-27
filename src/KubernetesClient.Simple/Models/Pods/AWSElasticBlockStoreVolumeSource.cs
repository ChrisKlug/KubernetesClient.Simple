namespace KubernetesClient.Simple.Models.Pods
{
    public class AWSElasticBlockStoreVolumeSource
    {
        public string FsType { get; set; }
        public int? Partition { get; set; }
        public bool? ReadOnly { get; set; }
        public string VolumeID { get; set; }
    }
}
