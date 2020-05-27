using System;

namespace KubernetesClient.Simple.Exceptions
{
    public class InvalidScopeException : Exception
    {
        public InvalidScopeException(string message) : base(message)
        {

        }
    }
}
