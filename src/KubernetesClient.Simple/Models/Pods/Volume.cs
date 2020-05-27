namespace KubernetesClient.Simple.Models.Pods
{
    public class Volume
    {
        public string Name { get; set; }
        public AWSElasticBlockStoreVolumeSource AwsElasticBlockStore { get; set; }
        public AzureDiskVolumeSource AzureDisk { get; set; }
        public AzureFileVolumeSource AzureFile { get; set; }
        public CephFSVolumeSource Cephfs { get; set; }
        public CinderVolumeSource Cinder { get; set; }
        public ConfigMapVolumeSource ConfigMap { get; set; }
        public CSIVolumeSource Csi { get; set; }
        public DownwardAPIVolumeSource DownwardAPI { get; set; }
        public EmptyDirVolumeSource EmptyDir { get; set; }

        // TODO: Implement the rest!!!

        //public V1FCVolumeSource Fc { get; set; }
        //public V1FlexVolumeSource FlexVolume { get; set; }
        //public V1FlockerVolumeSource Flocker { get; set; }
        //public V1GCEPersistentDiskVolumeSource GcePersistentDisk { get; set; }
        //public V1GitRepoVolumeSource GitRepo { get; set; }
        //public V1GlusterfsVolumeSource Glusterfs { get; set; }
        //public V1HostPathVolumeSource HostPath { get; set; }
        //public V1ISCSIVolumeSource Iscsi { get; set; }
        //public V1NFSVolumeSource Nfs { get; set; }
        //public V1PersistentVolumeClaimVolumeSource PersistentVolumeClaim { get; set; }
        //public V1PhotonPersistentDiskVolumeSource PhotonPersistentDisk { get; set; }
        //public V1PortworxVolumeSource PortworxVolume { get; set; }
        //public V1ProjectedVolumeSource Projected { get; set; }
        //public V1QuobyteVolumeSource Quobyte { get; set; }
        //public V1RBDVolumeSource Rbd { get; set; }
        //public V1ScaleIOVolumeSource ScaleIO { get; set; }
        //public V1SecretVolumeSource Secret { get; set; }
        //public V1StorageOSVolumeSource Storageos { get; set; }
        //public V1VsphereVirtualDiskVolumeSource VsphereVolume { get; set; }
    }
}
