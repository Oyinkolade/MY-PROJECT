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
    public partial class ExercisesForm : Form
    {
        private Dictionary<string, ExerciseDetail> exercises;

        public ExercisesForm()
        {
            InitializeComponent();
        }
        private void ExercisesForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Load event fired!");
            try
            {
                string filePath = "exercises.json"; // Ensure this file is in the output directory
                exercises = ExerciseLoader.LoadExercises(filePath);

                // Debug: Check the number of topics loaded
                MessageBox.Show("Topics loaded: " + exercises.Count.ToString());

                listBoxExTopics.Items.Clear();
                foreach (string topic in exercises.Keys)
                {
                    listBoxExTopics.Items.Add(topic);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading exercises: " + ex.Message);
            }
        }



        private void listBoxExTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Topic selected!");
            if (listBoxExTopics.SelectedItem != null)
            {
                string topic = listBoxExTopics.SelectedItem.ToString();
                if (exercises != null && exercises.ContainsKey(topic))
                {
                    ExerciseDetail detail = exercises[topic];
                    string output = "Exercises:\n" + detail.Exercises;
                    richTextBoxExercise.Text = output;
                }
                else
                {
                    richTextBoxExercise.Text = "No exercise details available for this topic.";
                }
            }
        }
    }
}
