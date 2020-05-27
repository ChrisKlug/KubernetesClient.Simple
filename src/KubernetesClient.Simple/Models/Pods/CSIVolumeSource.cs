using System.Collections.Generic;

namespace KubernetesClient.Simple.Models.Pods
{
    public class CSIVolumeSource
    {
        public string Driver { get; set; }
        public string FsType { get; set; }
        public LocalObjectReference NodePublishSecretRef { get; set; }
        public bool? ReadOnly { get; set; }
        public IDictionary<string, string> VolumeAttributes { get; set; }
    }
}
