using System.Collections.Generic;

namespace KubernetesClient.Simple.Models.Pods
{
    public class ConfigMapVolumeSource
    {
        public int? DefaultMode { get; set; }
        public IList<KeyToPath> Items { get; set; }
        public string Name { get; set; }
        public bool? Optional { get; set; }
    }
}
