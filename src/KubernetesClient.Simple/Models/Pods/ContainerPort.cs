using Newtonsoft.Json;

namespace KubernetesClient.Simple.Models.Pods
{
    public class ContainerPort
    {
        [JsonProperty("ContainerPort")]
        public int Port { get; set; }
        public string HostIP { get; set; }
        public int? HostPort { get; set; }
        public string Name { get; set; }
        public string Protocol { get; set; }
    }
}
