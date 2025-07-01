using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Programming_Guide
{
    public static class ReferenceLoader
    {
        public static Dictionary<string, ReferenceDetail> LoadReferences(string filePath)
        {
            string json = File.ReadAllText(filePath);
            var references = JsonConvert.DeserializeObject<Dictionary<string, ReferenceDetail>>(json);
            return references;
        }
    }
}
