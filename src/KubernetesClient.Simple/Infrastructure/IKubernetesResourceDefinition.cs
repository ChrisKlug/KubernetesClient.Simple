namespace KubernetesClient.Simple.Infrastructure
{
    public interface IKubernetesResourceDefinition
    {
        string Group { get; }
        string Kind { get; }
        string Singular { get; }
        string Plural { get; }
        string ApiVersion { get; }
        ResourceScope Scope { get; }
        KubernetesVersion[] SupportedVersions { get; }
    }
}