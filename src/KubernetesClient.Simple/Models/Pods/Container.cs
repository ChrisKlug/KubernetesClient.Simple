using System;
using System.Collections.Generic;
using System.Text;

namespace KubernetesClient.Simple.Models.Pods
{
    public class Container
    {
        public IList<string> Args { get; set; }
        public IList<string> Command { get; set; }
        public IList<EnvVar> Env { get; set; }
        public IList<EnvFromSource> EnvFrom { get; set; }
        public string Image { get; set; }
        public string ImagePullPolicy { get; set; }
        public Lifecycle Lifecycle { get; set; }
        public Probe LivenessProbe { get; set; }
        public string Name { get; set; }
        public IList<ContainerPort> Ports { get; set; }
        public Probe ReadinessProbe { get; set; }
        public ResourceRequirements Resources { get; set; }
        public SecurityContext SecurityContext { get; set; }
        public Probe StartupProbe { get; set; }
        public bool? Stdin { get; set; }
        public bool? StdinOnce { get; set; }
        public string TerminationMessagePath { get; set; }
        public string TerminationMessagePolicy { get; set; }
        public bool? Tty { get; set; }
        public IList<VolumeDevice> VolumeDevices { get; set; }
        public IList<VolumeMount> VolumeMounts { get; set; }
        public string WorkingDir { get; set; }
    }
}
