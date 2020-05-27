using KubernetesClient.Simple.Infrastructure;

namespace KubernetesClient.Simple.v1_15.Models
{
    [KubernetesResource("Pod", "core", "v1", "pods", "pod", ResourceScope.Namespace, KubernetesVersion.v1_15)]
    public class Pod : Simple.Models.Pods.Pod
    {
    }
}
