namespace KubernetesClient.Simple.Models.Pods
{
    public class WindowsSecurityContextOptions
    {
        public string GmsaCredentialSpec { get; set; }
        public string GmsaCredentialSpecName { get; set; }
        public string RunAsUserName { get; set; }
    }
}
