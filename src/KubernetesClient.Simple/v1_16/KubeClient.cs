using KubernetesClient.Simple.Infrastructure;
using System;
using System.Linq;

namespace KubernetesClient.Simple.v1_16
{
    public class KubeClient : KubeClientBase, IKubeClient
    {
        public KubeClient(IUrlGenerator urlGenerator, IHttpClientAccessor httpClientAccessor,
            IRequestCredentialsProvider requestCredentialsProvider, IResourceDefinitionRepository resourceDefinitionRepository) :
            base(urlGenerator, httpClientAccessor, requestCredentialsProvider, resourceDefinitionRepository)
        {

        }

        protected override void EnsureResourceDefinitionSupport(IKubernetesResourceDefinition resourceDefinition)
        {
            if (!resourceDefinition.SupportedVersions.Contains(KubernetesVersion.v1_16))
            {
                throw new NotSupportedException();
            }
        }
    }
}
