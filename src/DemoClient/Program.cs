using DemoClient.CustomResource;
using k8s;
using KubernetesClient.Simple;
using KubernetesClient.Simple.v1_15.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DemoClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = KubeClient.Create(KubernetesVersion.v1_15);

            var pods = await client.List<Pod>("docker");

            var pods2 = await client.ListRaw<Pod>("docker");

            var allPods = await client.List<Pod>();

            var allPods2 = await client.ListRaw<Pod>();

            var dockerPod = await client.Get<Pod>("docker", pods.Items.First().Metadata.Name);

            var foo = await client.Get<Foo>("default", "a-foo");

            await client.Patch(pods.Items.First(), (resource, patch) => {
                resource.Metadata.Annotations.Add("key", "value");
                patch.Replace(x => x.Metadata.Annotations, foo.Metadata.Annotations);
            });

            Console.ReadKey();
        }
    }
}
