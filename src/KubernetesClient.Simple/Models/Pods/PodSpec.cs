using System.Collections.Generic;

namespace KubernetesClient.Simple.Models.Pods
{
    public class PodSpec
    {
        public long? ActiveDeadlineSeconds { get; set; }
        public Affinity Affinity { get; set; }
        public bool? AutomountServiceAccountToken { get; set; }
        public IList<Container> Containers { get; set; }
        public PodDNSConfig DnsConfig { get; set; }
        public string DnsPolicy { get; set; }
        public bool? EnableServiceLinks { get; set; }
        public IList<EphemeralContainer> EphemeralContainers { get; set; }
        public IList<HostAlias> HostAliases { get; set; }
        public bool? HostIPC { get; set; }
        public bool? HostNetwork { get; set; }
        public bool? HostPID { get; set; }
        public string Hostname { get; set; }
        public IList<LocalObjectReference> ImagePullSecrets { get; set; }
        public IList<Container> InitContainers { get; set; }
        public string NodeName { get; set; }
        public IDictionary<string, string> NodeSelector { get; set; }
        public IDictionary<string, ResourceQuantity> Overhead { get; set; }
        public string PreemptionPolicy { get; set; }
        public int? Priority { get; set; }
        public string PriorityClassName { get; set; }
        public IList<PodReadinessGate> ReadinessGates { get; set; }
        public string RestartPolicy { get; set; }
        public string RuntimeClassName { get; set; }
        public string SchedulerName { get; set; }
        public PodSecurityContext SecurityContext { get; set; }
        public string ServiceAccount { get; set; }
        public string ServiceAccountName { get; set; }
        public bool? ShareProcessNamespace { get; set; }
        public string Subdomain { get; set; }
        public long? TerminationGracePeriodSeconds { get; set; }
        public IList<Toleration> Tolerations { get; set; }
        public IList<TopologySpreadConstraint> TopologySpreadConstraints { get; set; }
        public IList<Volume> Volumes { get; set; }
    }
}
