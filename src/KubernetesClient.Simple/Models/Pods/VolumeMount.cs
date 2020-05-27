namespace KubernetesClient.Simple.Models.Pods
{
    public class VolumeMount
    {
        public string MountPath { get; set; }
        public string MountPropagation { get; set; }
        public string Name { get; set; }
        public bool? ReadOnly { get; set; }
        public string SubPath { get; set; }
        public string SubPathExpr { get; set; }
    }
}
