using System;

namespace KubernetesClient.Simple.Infrastructure
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class KubernetesResourceAttribute : Attribute, IKubernetesResourceDefinition
    {
        public KubernetesResourceAttribute(string kind, string group, string version, string plural, string singular, ResourceScope scope, KubernetesVersion supportedVersion)
            : this(kind, group, version, plural, singular, scope, new [] { supportedVersion })
        {
        }
        public KubernetesResourceAttribute(string kind, string group, string version, string plural, string singular, ResourceScope scope, KubernetesVersion[] supportedVersions)
        {
            Kind = kind;
            Group = group;
            ApiVersion = version;
            Plural = plural;
            Singular = singular;
            Scope = scope;
            SupportedVersions = supportedVersions;
        }

        public string Kind { get; }
        public string Group { get; }
        public string ApiVersion { get; }
        public string Plural { get; }
        public string Singular { get; }
        public ResourceScope Scope { get; }
        public KubernetesVersion[] SupportedVersions { get; }
    }
}
