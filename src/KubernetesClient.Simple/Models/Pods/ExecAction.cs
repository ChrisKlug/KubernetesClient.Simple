using System.Collections.Generic;

namespace KubernetesClient.Simple.Models.Pods
{
    public class ExecAction
    {
        public IList<string> Command { get; set; }
    }
}
