using KubernetesClient.Simple;
using KubernetesClient.Simple.Infrastructure;
using KubernetesClient.Simple.Models;

namespace DemoClient.CustomResource
{
    [KubernetesResource("Foo", "demos.fearofoblivion.com", "v1", "foos", "foo", ResourceScope.Namespace, KubernetesVersion.v1_15)]
    public class Foo
    {
        public const string StatusAnnotationName = "demos.fearofoblivion.com/foo-status";

        public string ApiVersion { get; set; }
        public string Kind { get; set; }
        public ObjectMeta Metadata { get; set; }
        public FooSpec Spec { get; set; }
        public string Status => Metadata.Annotations.ContainsKey(StatusAnnotationName) ? Metadata.Annotations[StatusAnnotationName] : null;

        public class FooSpec
        {
            public string Value1 { get; set; }
            public string Value2 { get; set; }
            public int Value3 { get; set; }
            public int Value4 { get; set; }
        }
    }
}
