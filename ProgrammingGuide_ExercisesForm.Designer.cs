namespace Programming_Guide
{
    partial class ExercisesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxExTopics = new ListBox();
            richTextBoxExercise = new RichTextBox();
            SuspendLayout();
            // 
            // listBoxExTopics
            // 
            listBoxExTopics.FormattingEnabled = true;
            listBoxExTopics.ItemHeight = 25;
            listBoxExTopics.Location = new Point(198, 12);
            listBoxExTopics.Name = "listBoxExTopics";
            listBoxExTopics.Size = new Size(449, 129);
            listBoxExTopics.TabIndex = 0;
            listBoxExTopics.SelectedIndexChanged += listBoxExTopics_SelectedIndexChanged;
            // 
            // richTextBoxExercise
            // 
            richTextBoxExercise.Location = new Point(45, 171);
            richTextBoxExercise.Name = "richTextBoxExercise";
            richTextBoxExercise.Size = new Size(707, 229);
            richTextBoxExercise.TabIndex = 1;
            richTextBoxExercise.Text = "";
            // 
            // ExercisesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBoxExercise);
            Controls.Add(listBoxExTopics);
            Name = "ExercisesForm";
            Text = "ExercisesForm";
            Load += ExercisesForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxExTopics;
        private RichTextBox richTextBoxExercise;
    }
}
