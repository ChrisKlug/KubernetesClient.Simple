﻿namespace KubernetesClient.Simple.Models.Pods
{
    public class SELinuxOptions
    {
        public string Level { get; set; }
        public string Role { get; set; }
        public string Type { get; set; }
        public string User { get; set; }
    }
}
