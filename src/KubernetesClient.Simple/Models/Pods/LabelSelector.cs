﻿using System.Collections.Generic;

namespace KubernetesClient.Simple.Models.Pods
{
    public class LabelSelector
    {
        public IList<LabelSelectorRequirement> MatchExpressions { get; set; }
        public IDictionary<string, string> MatchLabels { get; set; }
    }
}
