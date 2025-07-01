namespace Programming_Guide
{
    partial class PracticeForm
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
            listBoxPQTopics = new ListBox();
            flowLayoutPanelQuestions = new FlowLayoutPanel();
            buttonSubmit = new Button();
            labelScore = new Label();
            buttonReview = new Button();
            SuspendLayout();
            // 
            // listBoxPQTopics
            // 
            listBoxPQTopics.FormattingEnabled = true;
            listBoxPQTopics.ItemHeight = 25;
            listBoxPQTopics.Location = new Point(20, 20);
            listBoxPQTopics.Name = "listBoxPQTopics";
            listBoxPQTopics.Size = new Size(200, 179);
            listBoxPQTopics.TabIndex = 0;
            listBoxPQTopics.SelectedIndexChanged += listBoxPQTopics_SelectedIndexChanged;
            // 
            // flowLayoutPanelQuestions
            // 
            flowLayoutPanelQuestions.AutoScroll = true;
            flowLayoutPanelQuestions.Location = new Point(240, 20);
            flowLayoutPanelQuestions.Name = "flowLayoutPanelQuestions";
            flowLayoutPanelQuestions.Size = new Size(500, 400);
            flowLayoutPanelQuestions.TabIndex = 1;
            flowLayoutPanelQuestions.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelQuestions.WrapContents = false;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(240, 426);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(112, 34);
            buttonSubmit.TabIndex = 2;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // labelScore
            // 
            labelScore.Location = new Point(358, 426);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(264, 34);
            labelScore.TabIndex = 3;
            // 
            // buttonReview
            // 
            buttonReview.Location = new Point(628, 426);
            buttonReview.Name = "buttonReview";
            buttonReview.Size = new Size(112, 34);
            buttonReview.TabIndex = 4;
            buttonReview.Text = "Review";
            buttonReview.UseVisualStyleBackColor = true;
            buttonReview.Click += buttonReview_Click;
            // 
            // PracticeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 596);
            Controls.Add(buttonReview);
            Controls.Add(labelScore);
            Controls.Add(buttonSubmit);
            Controls.Add(flowLayoutPanelQuestions);
            Controls.Add(listBoxPQTopics);
            Name = "PracticeForm";
            Text = "PracticeForm";
            Load += PracticeForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxPQTopics;
        private FlowLayoutPanel flowLayoutPanelQuestions;
        private Button buttonSubmit;
        private Label labelScore;
        private Button buttonReview;
    }
}