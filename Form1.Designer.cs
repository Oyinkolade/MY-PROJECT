namespace Programming_Guide
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            lessonsToolStripMenuItem = new ToolStripMenuItem();
            exercisesToolStripMenuItem = new ToolStripMenuItem();
            practiceToolStripMenuItem = new ToolStripMenuItem();
            referenceToolStripMenuItem = new ToolStripMenuItem();
            textBoxSearch = new TextBox();
            textBox1 = new TextBox();
            syntaxToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(771, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(349, 44);
            label1.TabIndex = 0;
            label1.Text = "Programming Guide";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, lessonsToolStripMenuItem, exercisesToolStripMenuItem, practiceToolStripMenuItem, referenceToolStripMenuItem, syntaxToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1293, 33);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(77, 29);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            homeToolStripMenuItem.MouseEnter += Link_MouseEnter;
            homeToolStripMenuItem.MouseLeave += Link_MouseLeave;
            // 
            // lessonsToolStripMenuItem
            // 
            lessonsToolStripMenuItem.Name = "lessonsToolStripMenuItem";
            lessonsToolStripMenuItem.Size = new Size(90, 29);
            lessonsToolStripMenuItem.Text = "Lessons";
            lessonsToolStripMenuItem.Click += lessonsToolStripMenuItem_Click;
            lessonsToolStripMenuItem.MouseEnter += Link_MouseEnter;
            lessonsToolStripMenuItem.MouseLeave += Link_MouseLeave;
            // 
            // exercisesToolStripMenuItem
            // 
            exercisesToolStripMenuItem.Name = "exercisesToolStripMenuItem";
            exercisesToolStripMenuItem.Size = new Size(97, 29);
            exercisesToolStripMenuItem.Text = "Exercises";
            exercisesToolStripMenuItem.Click += exercisesToolStripMenuItem_Click;
            exercisesToolStripMenuItem.MouseEnter += Link_MouseEnter;
            exercisesToolStripMenuItem.MouseLeave += Link_MouseLeave;
            // 
            // practiceToolStripMenuItem
            // 
            practiceToolStripMenuItem.Name = "practiceToolStripMenuItem";
            practiceToolStripMenuItem.Size = new Size(173, 29);
            practiceToolStripMenuItem.Text = "Practice Questions";
            practiceToolStripMenuItem.Click += practiceToolStripMenuItem_Click;
            // 
            // referenceToolStripMenuItem
            // 
            referenceToolStripMenuItem.Name = "referenceToolStripMenuItem";
            referenceToolStripMenuItem.Size = new Size(104, 29);
            referenceToolStripMenuItem.Text = "Reference";
            referenceToolStripMenuItem.Click += referenceToolStripMenuItem_Click;
            referenceToolStripMenuItem.MouseEnter += Link_MouseEnter;
            referenceToolStripMenuItem.MouseLeave += Link_MouseLeave;
            // 
            // textBoxSearch
            // 
            textBoxSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxSearch.Location = new Point(583, 155);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Search Here…";
            textBoxSearch.Size = new Size(328, 44);
            textBoxSearch.TabIndex = 3;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            textBoxSearch.KeyDown += textBoxSearch_KeyDown;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(583, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(484, 44);
            textBox1.TabIndex = 4;
            textBox1.Text = "Search For A Programming Language";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // syntaxToolStripMenuItem
            // 
            syntaxToolStripMenuItem.Name = "syntaxToolStripMenuItem";
            syntaxToolStripMenuItem.Size = new Size(79, 29);
            syntaxToolStripMenuItem.Text = "Syntax";
            syntaxToolStripMenuItem.Click += syntaxToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 666);
            Controls.Add(textBox1);
            Controls.Add(textBoxSearch);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Arial Narrow", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.DarkBlue;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Programming Guide";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem lessonsToolStripMenuItem;
        private ToolStripMenuItem exercisesToolStripMenuItem;
        private ToolStripMenuItem referenceToolStripMenuItem;
        private TextBox textBoxSearch;
        private ToolStripMenuItem practiceToolStripMenuItem;
        private TextBox textBox1;
        private ToolStripMenuItem syntaxToolStripMenuItem;
    }
}
