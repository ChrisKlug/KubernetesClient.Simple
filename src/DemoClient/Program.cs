using DemoClient.CustomResource;
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

            var pods2 = await client.ListRaw<Pod>("default");

            var dockerPod = await client.Get<Pod>("docker", pods.First().Metadata.Name);

            var foo = await client.Get<Foo>("default", "a-foo");

            Console.ReadKey();
        }
    }
}
