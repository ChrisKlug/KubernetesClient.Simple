using KubernetesClient.Simple.Infrastructure;

namespace KubernetesClient.Simple.v1_16.Models
{
    [KubernetesResource("Pod", "core", "v1", "pods", "pod", ResourceScope.Namespace, KubernetesVersion.v1_16)]
    public class Pod : Simple.Models.Pods.Pod
    {
    }
}
