using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Programming_Guide
{
    public class SyntaxDetail
    {
        public Dictionary<string, string> DocumentStructure { get; set; }
        public Dictionary<string, object> BasicTags { get; set; }
        public Dictionary<string, string> SemanticElements { get; set; }
        public Dictionary<string, string> Attributes { get; set; }
        public Dictionary<string, string> ListsAndTables { get; set; }
        public Dictionary<string, string> Forms { get; set; }
        public Dictionary<string, string> Multimedia { get; set; }
    }
    public static class SyntaxLoader
    {
        public static Dictionary<string, SyntaxDetail> LoadSyntaxes(string filePath)
        {
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Dictionary<string, SyntaxDetail>>(json);
        }
    }
}
