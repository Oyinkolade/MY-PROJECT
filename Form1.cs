namespace Programming_Guide
{
    public partial class Form1 : Form
    {
        private Dictionary<string, LessonDetail> lessons;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lessonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LessonsForm lessonsForm = new LessonsForm();
            lessonsForm.Show();
        }

        private void exercisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExercisesForm exercisesForm = new ExercisesForm();
            exercisesForm.Show();
        }

        private void referenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReferenceForm referenceForm = new ReferenceForm();
            referenceForm.Show();
        }

        private void Link_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Label lbl)
            {
                // Change text color to LightBlue on hover and underline the text
                lbl.ForeColor = Color.LightBlue;
                lbl.Font = new Font(lbl.Font, FontStyle.Underline);
            }
        }

        private void Link_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label lbl)
            {
                // Revert text color to White and remove underline
                lbl.ForeColor = Color.White;
                lbl.Font = new Font(lbl.Font, FontStyle.Regular);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                var topic = textBoxSearch.Text.Trim();
                if (lessons.ContainsKey(topic))
                {
                    var lf = new LessonsForm();
                    lf.Show();
                    lf.PreselectTopic(topic);  // defined in LessonsForm
                }
                else
                {
                    MessageBox.Show(
                      $"\"{topic}\" not found. Please choose a valid language.",
                      "Not Found",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lessons = LessonLoader.LoadLessons("lessons.json");

            // Build autocomplete list
            var auto = new AutoCompleteStringCollection();
            auto.AddRange(lessons.Keys.ToArray());
            textBoxSearch.AutoCompleteCustomSource = auto;

#if NET6_0_OR_GREATER
            textBoxSearch.PlaceholderText = "Search Here…";
#endif
        }

        private void practiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pf = new PracticeForm();
            pf.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void syntaxToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
