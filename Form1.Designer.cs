namespace Calculator
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
            display_textbox = new TextBox();
            sin_button = new Button();
            cos_button = new Button();
            tan_button = new Button();
            log_button = new Button();
            zero_button = new Button();
            equal_to_button = new Button();
            decimal_point_button = new Button();
            one_button = new Button();
            two_button = new Button();
            three_button = new Button();
            four_button = new Button();
            five_button = new Button();
            six_button = new Button();
            seven_button = new Button();
            eight_button = new Button();
            nine_button = new Button();
            multiplication_button = new Button();
            addition_button = new Button();
            subtraction_button = new Button();
            division_button = new Button();
            clear_button = new Button();
            SuspendLayout();
            // 
            // display_textbox
            // 
            display_textbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            display_textbox.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            display_textbox.Location = new Point(12, 12);
            display_textbox.Multiline = true;
            display_textbox.Name = "display_textbox";
            display_textbox.Size = new Size(609, 133);
            display_textbox.TabIndex = 0;
            // 
            // sin_button
            // 
            sin_button.Location = new Point(12, 169);
            sin_button.Name = "sin_button";
            sin_button.Size = new Size(183, 80);
            sin_button.TabIndex = 2;
            sin_button.Text = "sin";
            sin_button.UseVisualStyleBackColor = true;
            sin_button.Click += sin_button_Click;
            // 
            // cos_button
            // 
            cos_button.Location = new Point(218, 169);
            cos_button.Name = "cos_button";
            cos_button.Size = new Size(204, 80);
            cos_button.TabIndex = 3;
            cos_button.Text = "cos";
            cos_button.UseVisualStyleBackColor = true;
            cos_button.Click += cos_button_Click;
            // 
            // tan_button
            // 
            tan_button.Location = new Point(438, 169);
            tan_button.Name = "tan_button";
            tan_button.Size = new Size(183, 80);
            tan_button.TabIndex = 4;
            tan_button.Text = "tan";
            tan_button.UseVisualStyleBackColor = true;
            tan_button.Click += tan_button_Click;
            // 
            // log_button
            // 
            log_button.Location = new Point(304, 281);
            log_button.Name = "log_button";
            log_button.Size = new Size(118, 80);
            log_button.TabIndex = 5;
            log_button.Text = "log";
            log_button.UseVisualStyleBackColor = true;
            log_button.Click += log_button_Click;
            // 
            // zero_button
            // 
            zero_button.Location = new Point(12, 597);
            zero_button.Name = "zero_button";
            zero_button.Size = new Size(118, 80);
            zero_button.TabIndex = 6;
            zero_button.Text = "0";
            zero_button.UseVisualStyleBackColor = true;
            zero_button.Click += zero_button_Click;
            // 
            // equal_to_button
            // 
            equal_to_button.Location = new Point(450, 597);
            equal_to_button.Name = "equal_to_button";
            equal_to_button.Size = new Size(171, 80);
            equal_to_button.TabIndex = 7;
            equal_to_button.Text = "=";
            equal_to_button.UseVisualStyleBackColor = true;
            equal_to_button.Click += equal_to_button_Click;
            // 
            // decimal_point_button
            // 
            decimal_point_button.Location = new Point(158, 597);
            decimal_point_button.Name = "decimal_point_button";
            decimal_point_button.Size = new Size(118, 80);
            decimal_point_button.TabIndex = 8;
            decimal_point_button.Text = ".";
            decimal_point_button.UseVisualStyleBackColor = true;
            decimal_point_button.Click += decimal_point_button_Click;
            // 
            // one_button
            // 
            one_button.Location = new Point(12, 493);
            one_button.Name = "one_button";
            one_button.Size = new Size(118, 80);
            one_button.TabIndex = 9;
            one_button.Text = "1";
            one_button.UseVisualStyleBackColor = true;
            one_button.Click += one_button_Click;
            // 
            // two_button
            // 
            two_button.Location = new Point(158, 493);
            two_button.Name = "two_button";
            two_button.Size = new Size(118, 80);
            two_button.TabIndex = 10;
            two_button.Text = "2";
            two_button.UseVisualStyleBackColor = true;
            two_button.Click += two_button_Click;
            // 
            // three_button
            // 
            three_button.Location = new Point(304, 597);
            three_button.Name = "three_button";
            three_button.Size = new Size(118, 80);
            three_button.TabIndex = 11;
            three_button.Text = "3";
            three_button.UseVisualStyleBackColor = true;
            three_button.Click += three_button_Click;
            // 
            // four_button
            // 
            four_button.Location = new Point(12, 390);
            four_button.Name = "four_button";
            four_button.Size = new Size(118, 80);
            four_button.TabIndex = 12;
            four_button.Text = "4";
            four_button.UseVisualStyleBackColor = true;
            four_button.Click += four_button_Click;
            // 
            // five_button
            // 
            five_button.Location = new Point(158, 390);
            five_button.Name = "five_button";
            five_button.Size = new Size(118, 80);
            five_button.TabIndex = 13;
            five_button.Text = "5";
            five_button.UseVisualStyleBackColor = true;
            five_button.Click += five_button_Click;
            // 
            // six_button
            // 
            six_button.Location = new Point(304, 493);
            six_button.Name = "six_button";
            six_button.Size = new Size(118, 80);
            six_button.TabIndex = 14;
            six_button.Text = "6";
            six_button.UseVisualStyleBackColor = true;
            six_button.Click += six_button_Click;
            // 
            // seven_button
            // 
            seven_button.Location = new Point(12, 281);
            seven_button.Name = "seven_button";
            seven_button.Size = new Size(118, 80);
            seven_button.TabIndex = 15;
            seven_button.Text = "7";
            seven_button.UseVisualStyleBackColor = true;
            seven_button.Click += seven_button_Click;
            // 
            // eight_button
            // 
            eight_button.Location = new Point(158, 281);
            eight_button.Name = "eight_button";
            eight_button.Size = new Size(118, 80);
            eight_button.TabIndex = 16;
            eight_button.Text = "8";
            eight_button.UseVisualStyleBackColor = true;
            eight_button.Click += eight_button_Click;
            // 
            // nine_button
            // 
            nine_button.Location = new Point(304, 390);
            nine_button.Name = "nine_button";
            nine_button.Size = new Size(118, 80);
            nine_button.TabIndex = 17;
            nine_button.Text = "9";
            nine_button.UseVisualStyleBackColor = true;
            nine_button.Click += nine_button_Click;
            // 
            // multiplication_button
            // 
            multiplication_button.Location = new Point(438, 390);
            multiplication_button.Name = "multiplication_button";
            multiplication_button.Size = new Size(81, 80);
            multiplication_button.TabIndex = 18;
            multiplication_button.Text = "x";
            multiplication_button.UseVisualStyleBackColor = true;
            multiplication_button.Click += multiplication_button_Click;
            // 
            // addition_button
            // 
            addition_button.Location = new Point(438, 493);
            addition_button.Name = "addition_button";
            addition_button.Size = new Size(81, 80);
            addition_button.TabIndex = 19;
            addition_button.Text = "+";
            addition_button.UseVisualStyleBackColor = true;
            addition_button.Click += addition_button_Click;
            // 
            // subtraction_button
            // 
            subtraction_button.Location = new Point(545, 493);
            subtraction_button.Name = "subtraction_button";
            subtraction_button.Size = new Size(79, 80);
            subtraction_button.TabIndex = 20;
            subtraction_button.Text = "-";
            subtraction_button.UseVisualStyleBackColor = true;
            subtraction_button.Click += subtraction_button_Click;
            // 
            // division_button
            // 
            division_button.Location = new Point(545, 390);
            division_button.Name = "division_button";
            division_button.Size = new Size(81, 80);
            division_button.TabIndex = 21;
            division_button.Text = "÷";
            division_button.UseVisualStyleBackColor = true;
            division_button.Click += division_button_Click;
            // 
            // clear_button
            // 
            clear_button.Location = new Point(450, 281);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(171, 80);
            clear_button.TabIndex = 23;
            clear_button.Text = "AC";
            clear_button.UseVisualStyleBackColor = true;
            clear_button.Click += clear_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(633, 689);
            Controls.Add(clear_button);
            Controls.Add(division_button);
            Controls.Add(subtraction_button);
            Controls.Add(addition_button);
            Controls.Add(multiplication_button);
            Controls.Add(nine_button);
            Controls.Add(eight_button);
            Controls.Add(seven_button);
            Controls.Add(six_button);
            Controls.Add(five_button);
            Controls.Add(four_button);
            Controls.Add(three_button);
            Controls.Add(two_button);
            Controls.Add(one_button);
            Controls.Add(decimal_point_button);
            Controls.Add(equal_to_button);
            Controls.Add(zero_button);
            Controls.Add(log_button);
            Controls.Add(tan_button);
            Controls.Add(cos_button);
            Controls.Add(sin_button);
            Controls.Add(display_textbox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox display_textbox;
        private Button sin_button;
        private Button cos_button;
        private Button tan_button;
        private Button log_button;
        private Button zero_button;
        private Button equal_to_button;
        private Button decimal_point_button;
        private Button one_button;
        private Button two_button;
        private Button three_button;
        private Button four_button;
        private Button five_button;
        private Button six_button;
        private Button seven_button;
        private Button eight_button;
        private Button nine_button;
        private Button multiplication_button;
        private Button addition_button;
        private Button subtraction_button;
        private Button division_button;
        private Button clear_button;
    }
}
