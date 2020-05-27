using k8s;
using KubernetesClient.Simple.Infrastructure;
using System;

namespace KubernetesClient.Simple
{
    public static class KubeClient
    {
        public static IKubeClient Create(KubernetesVersion kubernetesVersion)
        {
            return KubernetesClientConfiguration.IsInCluster() ? ForInCluster(kubernetesVersion) : ForLocalProxy(kubernetesVersion);
        }
        public static IKubeClient ForLocalProxy(KubernetesVersion kubernetesVersion, string host = "http://localhost:8001")
        {
            var config = new KubernetesClientConfiguration { Host = host };
            var kubernetes = new Kubernetes(config);
            return Create(kubernetesVersion, kubernetes);
        }
        public static IKubeClient ForInCluster(KubernetesVersion kubernetesVersion)
        {
            var config = KubernetesClientConfiguration.InClusterConfig();
            var kubernetes = new Kubernetes(config);
            return Create(kubernetesVersion, kubernetes);
        }
        public static IKubeClient Create(KubernetesVersion kubernetesVersion, Kubernetes kubernetes)
        {
            IUrlGenerator urlGenerator = new DefaultUrlGenerator(kubernetes.BaseUri);
            IResourceDefinitionRepository resourceDefinitionRepository = new ResourceDefinitionRepository();
            IHttpClientAccessor httpClientAccessor = new KubernetesHttpClientAccessor(kubernetes);
            IRequestCredentialsProvider requestCredentialsProvider = new KubernetesRequestCredentialsProvider(kubernetes);

            return kubernetesVersion switch
            {
                KubernetesVersion.v1_15 => new v1_15.KubeClient(urlGenerator, httpClientAccessor, requestCredentialsProvider, resourceDefinitionRepository),
                KubernetesVersion.v1_16 => new v1_16.KubeClient(urlGenerator, httpClientAccessor, requestCredentialsProvider, resourceDefinitionRepository),
                _ => throw new Exception()
            };
        }
    }
}
