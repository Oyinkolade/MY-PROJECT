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
    public partial class PracticeForm : Form
    {
        // will hold the user’s selected option index for each question
        private int[] userAnswers;

        private Dictionary<string, List<PracticeQuestion>> practice;
        private string selectedLanguage;
        public PracticeForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int score = 0;
            var qs = practice[selectedLanguage];
            for (int i = 0; i < qs.Count; i++)
            {
                var grp = (GroupBox)flowLayoutPanelQuestions.Controls[i];
                int correct = qs[i].Answer;
                foreach (RadioButton rb in grp.Controls.OfType<RadioButton>())
                    if ((int)rb.Tag == correct && rb.Checked)
                        score++;
            }
            labelScore.Text = $"Score: {score} / {qs.Count}";
            buttonReview.Enabled = true;
        }
        private void Option_DoubleClick(object sender, EventArgs e)
        {
            var rb = (RadioButton)sender;
            // Clear previous highlight in this question
            foreach (RadioButton other in rb.Parent.Controls.OfType<RadioButton>())
                other.BackColor = SystemColors.Control;
            // Highlight this choice
            rb.BackColor = Color.Yellow;

            // Record the answer
            int qIndex = flowLayoutPanelQuestions.Controls.IndexOf(rb.Parent);
            userAnswers[qIndex] = (int)rb.Tag;
        }
        private void listBoxPQTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedLanguage = listBoxPQTopics.SelectedItem.ToString();
            var qs = practice[selectedLanguage];

            // reset answers
            userAnswers = new int[qs.Count];
            for (int i = 0; i < userAnswers.Length; i++)
                userAnswers[i] = -1;

            // clear old controls
            flowLayoutPanelQuestions.Controls.Clear();

            // build numbered questions
            for (int qi = 0; qi < qs.Count; qi++)
            {
                var question = qs[qi];

                // Create a GroupBox without question text in the title.
                var grp = new GroupBox
                {
                    Text = $"{qi + 1}.",  // you can leave just the number, or leave it blank if you prefer
                    AutoSize = true,
                    Width = flowLayoutPanelQuestions.ClientSize.Width - 20
                };

                // Create a Label for the question text.
                var lblQuestion = new Label
                {
                    Text = question.Question,
                    AutoSize = true,
                    Location = new Point(10, 20) // start a little down in the group box
                };
                grp.Controls.Add(lblQuestion);

                // Determine vertical spacing for the options starting after the question label.
                // Assume the label's height plus some padding.
                int startY = lblQuestion.Bottom + 10;

                // Add options (RadioButtons) below the label.
                for (int opt = 0; opt < question.Options.Count; opt++)
                {
                    char optionLabel = (char)('A' + opt);
                    var rb = new RadioButton
                    {
                        Text = $"{optionLabel}. {question.Options[opt]}",
                        Tag = opt,
                        AutoSize = true,
                        Location = new Point(10, startY + 25 * opt)
                    };

                    // Attach the double-click event handler for highlighting and recording.
                    rb.DoubleClick += Option_DoubleClick;
                    grp.Controls.Add(rb);
                }

                flowLayoutPanelQuestions.Controls.Add(grp);
            }


            // reset score & review
            labelScore.Text = "";
            buttonReview.Enabled = false;
        }

        private void buttonReview_Click(object sender, EventArgs e)
        {
            var qs = practice[selectedLanguage];
            for (int i = 0; i < qs.Count; i++)
            {
                var grp = (GroupBox)flowLayoutPanelQuestions.Controls[i];
                int correct = qs[i].Answer;
                foreach (RadioButton rb in grp.Controls.OfType<RadioButton>())
                    if ((int)rb.Tag == correct)
                    {
                        rb.ForeColor = Color.Green;
                        rb.Font = new Font(rb.Font, FontStyle.Bold);
                    }
            }
        }

        private void PracticeForm_Load(object sender, EventArgs e)
        {
            practice = PracticeLoader.LoadPractice("practice.json");
            listBoxPQTopics.Items.AddRange(practice.Keys.ToArray());
        }
    }
}
