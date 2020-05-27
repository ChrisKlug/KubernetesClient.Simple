using System.Collections.Generic;

namespace KubernetesClient.Simple.Models.Pods
{
    public class PodStatus
    {
        public IList<PodCondition> Conditions { get; set; }
        public IList<ContainerStatus> ContainerStatuses { get; set; }
        public IList<ContainerStatus> EphemeralContainerStatuses { get; set; }
        public string HostIP { get; set; }
        public IList<ContainerStatus> InitContainerStatuses { get; set; }
        public string Message { get; set; }
        public string NominatedNodeName { get; set; }
        public string Phase { get; set; }
        public string PodIP { get; set; }
        public IList<PodIP> PodIPs { get; set; }
        public string QosClass { get; set; }
        public string Reason { get; set; }
        public System.DateTime? StartTime { get; set; }
    }
}
