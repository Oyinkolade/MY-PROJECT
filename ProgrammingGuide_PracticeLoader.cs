using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Guide
{
    public class PracticeQuestion
    {
        public string Question { get; set; }
        public List<string> Options { get; set; }
        public int Answer { get; set; }
    }
    public static class PracticeLoader
    {
        public static Dictionary<string, List<PracticeQuestion>> LoadPractice(string filePath)
        {
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Dictionary<string, List<PracticeQuestion>>>(json);
        }
    }
}
