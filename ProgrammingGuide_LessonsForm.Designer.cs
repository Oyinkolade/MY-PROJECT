namespace Programming_Guide
{
    partial class LessonsForm
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
            label1 = new Label();
            listBoxTopics = new ListBox();
            label2 = new Label();
            richTextBoxLesson = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(133, 9);
            label1.Name = "label1";
            label1.Size = new Size(528, 37);
            label1.TabIndex = 0;
            label1.Text = "Welcome to the Lessons Section!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // listBoxTopics
            // 
            listBoxTopics.ItemHeight = 25;
            listBoxTopics.Location = new Point(236, 125);
            listBoxTopics.Name = "listBoxTopics";
            listBoxTopics.Size = new Size(283, 79);
            listBoxTopics.TabIndex = 1;
            listBoxTopics.SelectedIndexChanged += listBoxTopics_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(236, 76);
            label2.Name = "label2";
            label2.Size = new Size(283, 25);
            label2.TabIndex = 2;
            label2.Text = "What do you want to learn today?";
            // 
            // richTextBoxLesson
            // 
            richTextBoxLesson.Location = new Point(2, 222);
            richTextBoxLesson.Name = "richTextBoxLesson";
            richTextBoxLesson.Size = new Size(794, 216);
            richTextBoxLesson.TabIndex = 3;
            richTextBoxLesson.Text = "";
            // 
            // LessonsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBoxLesson);
            Controls.Add(label2);
            Controls.Add(listBoxTopics);
            Controls.Add(label1);
            Name = "LessonsForm";
            Text = "LessonsForm";
            Load += LessonsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBoxTopics;  // Changed from TextBox to ListBox
        private Label label2;
        private RichTextBox richTextBoxLesson;
    }
}
