using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Programming_Guide
{
    public static class LessonLoader
    {
        public static Dictionary<string, LessonDetail> LoadLessons(string filePath)
        {
            string json = File.ReadAllText(filePath);
            var lessons = JsonConvert.DeserializeObject<Dictionary<string, LessonDetail>>(json);
            return lessons;
        }
    }
}
