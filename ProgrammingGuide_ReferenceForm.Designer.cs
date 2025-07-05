namespace Programming_Guide
{
    partial class ReferenceForm
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
            listBoxRefTopics = new ListBox();
            richTextBoxReference = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(165, 9);
            label1.Name = "label1";
            label1.Size = new Size(324, 37);
            label1.TabIndex = 0;
            label1.Text = "Reference Materials";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listBoxRefTopics
            // 
            listBoxRefTopics.FormattingEnabled = true;
            listBoxRefTopics.ItemHeight = 25;
            listBoxRefTopics.Location = new Point(12, 74);
            listBoxRefTopics.Name = "listBoxRefTopics";
            listBoxRefTopics.Size = new Size(286, 354);
            listBoxRefTopics.TabIndex = 1;
            listBoxRefTopics.SelectedIndexChanged += listBoxRefTopics_SelectedIndexChanged;
            // 
            // richTextBoxReference
            // 
            richTextBoxReference.Location = new Point(346, 49);
            richTextBoxReference.Name = "richTextBoxReference";
            richTextBoxReference.Size = new Size(427, 379);
            richTextBoxReference.TabIndex = 2;
            richTextBoxReference.Text = "";
            // 
            // ReferenceForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBoxReference);
            Controls.Add(listBoxRefTopics);
            Controls.Add(label1);
            Name = "ReferenceForm";
            Text = "ReferenceForm";
            Load += ReferenceForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBoxRefTopics;
        private RichTextBox richTextBoxReference;
    }
}
