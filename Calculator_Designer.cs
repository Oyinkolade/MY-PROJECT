namespace My_First_App
{
    partial class Calculator
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
            Num1_textbox = new TextBox();
            Num2_textbox = new TextBox();
            Sum_button = new Button();
            Difference_button = new Button();
            Product_button = new Button();
            Share_button = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // Num1_textbox
            // 
            Num1_textbox.Location = new Point(334, 12);
            Num1_textbox.Name = "Num1_textbox";
            Num1_textbox.Size = new Size(150, 31);
            Num1_textbox.TabIndex = 0;
            // 
            // Num2_textbox
            // 
            Num2_textbox.Location = new Point(334, 86);
            Num2_textbox.Name = "Num2_textbox";
            Num2_textbox.Size = new Size(150, 31);
            Num2_textbox.TabIndex = 1;
            // 
            // Sum_button
            // 
            Sum_button.Location = new Point(90, 178);
            Sum_button.Name = "Sum_button";
            Sum_button.Size = new Size(112, 34);
            Sum_button.TabIndex = 2;
            Sum_button.Text = "Add";
            Sum_button.UseVisualStyleBackColor = true;
            Sum_button.Click += Sum_button_Click;
            // 
            // Difference_button
            // 
            Difference_button.Location = new Point(245, 178);
            Difference_button.Name = "Difference_button";
            Difference_button.Size = new Size(112, 34);
            Difference_button.TabIndex = 3;
            Difference_button.Text = "Subtract";
            Difference_button.UseVisualStyleBackColor = true;
            Difference_button.Click += Difference_button_Click;
            // 
            // Product_button
            // 
            Product_button.Location = new Point(399, 178);
            Product_button.Name = "Product_button";
            Product_button.Size = new Size(112, 34);
            Product_button.TabIndex = 4;
            Product_button.Text = "Multiply";
            Product_button.UseVisualStyleBackColor = true;
            Product_button.Click += Product_button_Click;
            // 
            // Share_button
            // 
            Share_button.Location = new Point(550, 178);
            Share_button.Name = "Share_button";
            Share_button.Size = new Size(112, 34);
            Share_button.TabIndex = 5;
            Share_button.Text = "Divide";
            Share_button.UseVisualStyleBackColor = true;
            Share_button.Click += Share_button_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(46, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 35);
            textBox1.TabIndex = 6;
            textBox1.Text = "Input First Number: ";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(26, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(248, 35);
            textBox2.TabIndex = 7;
            textBox2.Text = "Input Second Number: ";
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Share_button);
            Controls.Add(Product_button);
            Controls.Add(Difference_button);
            Controls.Add(Sum_button);
            Controls.Add(Num2_textbox);
            Controls.Add(Num1_textbox);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Num1_textbox;
        private TextBox Num2_textbox;
        private Button Sum_button;
        private Button Difference_button;
        private Button Product_button;
        private Button Share_button;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
