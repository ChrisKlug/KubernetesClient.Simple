namespace KubernetesClient.Simple.Models.Pods
{
    public class SecurityContext
    {
        public bool? AllowPrivilegeEscalation { get; set; }
        public Capabilities Capabilities { get; set; }
        public bool? Privileged { get; set; }
        public string ProcMount { get; set; }
        public bool? ReadOnlyRootFilesystem { get; set; }
        public long? RunAsGroup { get; set; }
        public bool? RunAsNonRoot { get; set; }
        public long? RunAsUser { get; set; }
        public SELinuxOptions SeLinuxOptions { get; set; }
        public WindowsSecurityContextOptions WindowsOptions { get; set; }
    }
}
