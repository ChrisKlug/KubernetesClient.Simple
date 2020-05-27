using KubernetesClient.Simple.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KubernetesClient.Simple
{
    public interface IKubeClient
    {
        Task<T> Get<T>(string name);
        Task<T> Get<T>(string @namespace, string name);
        Task<IEnumerable<T>> ListAll<T>();
        Task<IEnumerable<T>> List<T>(string @namespace);
        Task<ResourceList<T>> ListRaw<T>();
        Task<ResourceList<T>> ListRaw<T>(string @namespace);
    }
}
