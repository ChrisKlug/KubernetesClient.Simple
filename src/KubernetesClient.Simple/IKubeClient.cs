using KubernetesClient.Simple.Models;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KubernetesClient.Simple
{
    public interface IKubeClient
    {
        Task<T> Get<T>(string name);
        Task<T> Get<T>(string @namespace, string name);
        
        // TODO: Add extension method with IAsyncEnumerable
        Task<(IEnumerable<T> Items, string ContinuationToken)> List<T>(string @namespace = null, string continuationToken = null);
        Task<ResourceList<T>> ListRaw<T>(string @namespace = null, string continuationToken = null);

        Task<T> Patch<T>(T resource, Action<T, JsonPatchDocument<T>> patchAction) where T : class;
    }
}
