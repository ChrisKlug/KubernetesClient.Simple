using System.Collections.Generic;

namespace KubernetesClient.Simple.Models.Pods
{
    public class CephFSVolumeSource
    {
        public IList<string> Monitors { get; set; }
        public string Path { get; set; }
        public bool? ReadOnly { get; set; }
        public string SecretFile { get; set; }
        public LocalObjectReference SecretRef { get; set; }
        public string User { get; set; }
    }
}
