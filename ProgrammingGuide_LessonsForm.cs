using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Programming_Guide
{
    public partial class LessonsForm : Form
    {
        public void PreselectTopic(string topic)
        {
            if (!this.IsHandleCreated)
            {
                this.Load += (s, e) => PreselectTopic(topic);
                return;
            }
            listBoxTopics.SelectedItem = topic;
        }

        public LessonsForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private Dictionary<string, LessonDetail> lessons;

        private void LessonsForm_Load(object sender, EventArgs e)
        {
            string filePath = "lessons.json"; // Ensure this file is in the correct folder (e.g., project output directory)
            lessons = LessonLoader.LoadLessons(filePath);
            // Now you can use the 'lessons' dictionary to populate your UI controls.
            // Populate the ListBox with lesson topics (e.g., HTML, CSS, JavaScript, etc.)
            listBoxTopics.Items.Clear();
            foreach (string topic in lessons.Keys)
            {
                listBoxTopics.Items.Add(topic);
            }
        }

        private void listBoxTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTopics.SelectedItem != null)
            {
                string topic = listBoxTopics.SelectedItem.ToString();
                if (lessons != null && lessons.ContainsKey(topic))
                {
                    LessonDetail detail = lessons[topic];
                    string output = "";

                    // Tailor the output based on the selected topic
                    switch (topic)
                    {
                        case "CSS":
                            output += "Introduction:\n" + detail.Introduction + "\n\n" +
                                      "Syntax:\n" + detail.Syntax + "\n\n" +
                                      "Selectors and Properties:\n" + detail.SelectorsandProperties + "\n\n" +
                                      "Best Practices:\n" + detail.BestPractices + "\n\n" +
                                      "Exercises:\n" + detail.Exercises;
                            break;

                        case "HTML":
                            output += "Introduction:\n" + detail.Introduction + "\n\n" +
                                      "Syntax:\n" + detail.Syntax + "\n\n" +
                                      "Elements:\n" + detail.Elements + "\n\n" +
                                      "Best Practices:\n" + detail.BestPractices + "\n\n" +
                                      "Exercises:\n" + detail.Exercises;
                            break;

                        case "JavaScript":
                            output += "Introduction:\n" + detail.Introduction + "\n\n" +
                                      "Syntax:\n" + detail.Syntax + "\n\n" +
                                      "Data Types and Variables:\n" + detail.DataTypesandVariables + "\n\n" +
                                      "Control Structures:\n" + detail.ControlStructures + "\n\n" +
                                      "Functions and Events:\n" + detail.FunctionsandEvents + "\n\n" +
                                      "Best Practices:\n" + detail.BestPractices + "\n\n" +
                                      "Exercises:\n" + detail.Exercises;
                            break;

                        case "Python":
                            output += "Introduction:\n" + detail.Introduction + "\n\n" +
                                      "Syntax:\n" + detail.Syntax + "\n\n" +
                                      "Data Types and Variables:\n" + detail.DataTypesandVariables + "\n\n" +
                                      "Control Structures:\n" + detail.ControlStructures + "\n\n" +
                                      "Functions and Modules:\n" + detail.FunctionsandModules + "\n\n" +
                                      "Best Practices:\n" + detail.BestPractices + "\n\n" +
                                      "Exercises:\n" + detail.Exercises;
                            break;

                        case "PHP":
                            output += "Introduction:\n" + detail.Introduction + "\n\n" +
                                      "Syntax:\n" + detail.Syntax + "\n\n" +
                                      "Data Types and Variables:\n" + detail.DataTypesandVariables + "\n\n" +
                                      "Control Structures:\n" + detail.ControlStructures + "\n\n" +
                                      "Functions and Object-Oriented Programming:\n" + detail.FunctionsandObjectOrientedProgramming + "\n\n" +
                                      "Best Practices:\n" + detail.BestPractices + "\n\n" +
                                      "Exercises:\n" + detail.Exercises;
                            break;

                        case "SQL":
                            output += "Introduction:\n" + detail.Introduction + "\n\n" +
                                      "Syntax:\n" + detail.Syntax + "\n\n" +
                                      "Data Types and Tables:\n" + detail.DataTypesandTables + "\n\n" +
                                      "Queries and Joins:\n" + detail.QueriesandJoins + "\n\n" +
                                      "Best Practices:\n" + detail.BestPractices + "\n\n" +
                                      "Exercises:\n" + detail.Exercises;
                            break;

                        case "C#":
                            output += "Introduction:\n" + detail.Introduction + "\n\n" +
                                      "Syntax:\n" + detail.Syntax + "\n\n" +
                                      "Data Types and Variables:\n" + detail.DataTypesandVariables + "\n\n" +
                                      "Control Structures:\n" + detail.ControlStructures + "\n\n" +
                                      "Object-Oriented Programming:\n" + detail.ObjectOrientedProgramming + "\n\n" +
                                      "Best Practices:\n" + detail.BestPractices + "\n\n" +
                                      "Exercises:\n" + detail.Exercises;
                            break;

                        default:
                            output += "Introduction:\n" + detail.Introduction + "\n\n" +
                                      "Syntax:\n" + detail.Syntax + "\n\n" +
                                      "Best Practices:\n" + detail.BestPractices + "\n\n" +
                                      "Exercises:\n" + detail.Exercises;
                            break;
                    }

                    richTextBoxLesson.Text = output;
                }
                else
                {
                    richTextBoxLesson.Text = "No lesson details available for this topic.";
                }
            }
        }
    }
}
