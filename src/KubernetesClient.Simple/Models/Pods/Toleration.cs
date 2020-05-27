namespace KubernetesClient.Simple.Models.Pods
{
    public class Toleration
    {
        public string Effect { get; set; }
        public string Key { get; set; }
        public string OperatorProperty { get; set; }
        public long? TolerationSeconds { get; set; }
        public string Value { get; set; }
    }
}
