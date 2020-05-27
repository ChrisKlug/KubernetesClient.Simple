using System.Collections.Generic;

namespace KubernetesClient.Simple.Models.Pods
{
    public class DownwardAPIVolumeSource
    {
        public int? DefaultMode { get; set; }
        public IList<DownwardAPIVolumeFile> Items { get; set; }
    }
}
