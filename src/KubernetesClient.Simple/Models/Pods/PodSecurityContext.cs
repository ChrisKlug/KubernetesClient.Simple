using System.Collections.Generic;

namespace KubernetesClient.Simple.Models.Pods
{
    public class PodSecurityContext
    {
        public long? FsGroup { get; set; }
        public string FsGroupChangePolicy { get; set; }
        public long? RunAsGroup { get; set; }
        public bool? RunAsNonRoot { get; set; }
        public long? RunAsUser { get; set; }
        public SELinuxOptions SeLinuxOptions { get; set; }
        public IList<long?> SupplementalGroups { get; set; }
        public IList<Sysctl> Sysctls { get; set; }
        public WindowsSecurityContextOptions WindowsOptions { get; set; }
    }
}
