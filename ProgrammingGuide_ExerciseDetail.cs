using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Guide
{
    public class ExerciseDetail
    {
        [JsonProperty("Exercises")]
        public string Exercises { get; set; }
    }
}
