using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Guide
{
    public class ReferenceDetail
    {
        [JsonProperty("Key Concepts")]
        public string KeyConcepts { get; set; }

        [JsonProperty("Examples")]
        public string Examples { get; set; }

        [JsonProperty("Additional Resources")]
        public string AdditionalResources { get; set; }
    }
}
