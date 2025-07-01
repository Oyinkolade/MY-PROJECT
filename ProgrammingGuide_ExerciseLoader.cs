using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Guide
{
    public static class ExerciseLoader
    {
        public static Dictionary<string, ExerciseDetail> LoadExercises(string filePath)
        {
            string json = File.ReadAllText(filePath);
            var exercises = JsonConvert.DeserializeObject<Dictionary<string, ExerciseDetail>>(json);
            return exercises;
        }
    }
}
