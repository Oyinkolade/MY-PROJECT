using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Guide
{
    public class LessonDetail
    {
        [JsonProperty("Introduction")]
        public string Introduction { get; set; }

        [JsonProperty("Syntax")]
        public string Syntax { get; set; }

        [JsonProperty("Elements")]
        public string Elements { get; set; }  // For HTML, CSS, PHP, etc.

        [JsonProperty("Data Types and Variables")]
        public string DataTypesandVariables { get; set; } // For programming languages

        [JsonProperty("Control Structures")]
        public string ControlStructures { get; set; }

        [JsonProperty("Functions and Events")]
        public string FunctionsandEvents { get; set; }

        [JsonProperty("Best Practices")]
        public string BestPractices { get; set; }

        public string Exercises { get; set; }

        [JsonProperty("Selectors and Properties")]
        public string SelectorsandProperties { get; set; } // For CSS

        [JsonProperty("Functions and Object-Oriented Programming")]
        public string FunctionsandObjectOrientedProgramming { get; set; } // For PHP

        [JsonProperty("Data Types and Tables")]
        public string DataTypesandTables { get; set; } // For SQL

        [JsonProperty("Queries and Joins")]
        public string QueriesandJoins { get; set; } // For SQL

        [JsonProperty("Object-Oriented Programming")]
        public string ObjectOrientedProgramming { get; set; } // For C#

        [JsonProperty("Functions and Modules")]
        public string FunctionsandModules { get; set; }
    }
}
