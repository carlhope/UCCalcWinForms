namespace UCCalcWinForms
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
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            WragInput = new CheckBox();
            SupportInput = new CheckBox();
            ageInput = new CheckBox();
            coupleInput = new CheckBox();
            salaryInput = new TextBox();
            RentInput = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(273, 395);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(83, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(273, 342);
            button1.Name = "button1";
            button1.Size = new Size(83, 23);
            button1.TabIndex = 1;
            button1.Text = "Click me";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 60);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Net Salary";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 98);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 3;
            label2.Text = "Rent Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 128);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 4;
            label3.Text = "WRAG";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 169);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 5;
            label4.Text = "Support";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 228);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 6;
            label5.Text = "Over 18";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 271);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 7;
            label6.Text = "Are you a couple";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 403);
            label7.Name = "label7";
            label7.Size = new Size(109, 15);
            label7.TabIndex = 8;
            label7.Text = "UC Eligible amount";
            // 
            // WragInput
            // 
            WragInput.AutoSize = true;
            WragInput.Location = new Point(273, 124);
            WragInput.Name = "WragInput";
            WragInput.Size = new Size(83, 19);
            WragInput.TabIndex = 9;
            WragInput.Text = "checkBox1";
            WragInput.UseVisualStyleBackColor = true;
            // 
            // SupportInput
            // 
            SupportInput.AutoSize = true;
            SupportInput.Location = new Point(273, 165);
            SupportInput.Name = "SupportInput";
            SupportInput.Size = new Size(83, 19);
            SupportInput.TabIndex = 10;
            SupportInput.Text = "checkBox2";
            SupportInput.UseVisualStyleBackColor = true;
            // 
            // ageInput
            // 
            ageInput.AutoSize = true;
            ageInput.Location = new Point(273, 224);
            ageInput.Name = "ageInput";
            ageInput.Size = new Size(83, 19);
            ageInput.TabIndex = 11;
            ageInput.Text = "checkBox3";
            ageInput.UseVisualStyleBackColor = true;
            // 
            // coupleInput
            // 
            coupleInput.AutoSize = true;
            coupleInput.Location = new Point(273, 271);
            coupleInput.Name = "coupleInput";
            coupleInput.Size = new Size(83, 19);
            coupleInput.TabIndex = 12;
            coupleInput.Text = "checkBox4";
            coupleInput.UseVisualStyleBackColor = true;
            // 
            // salaryInput
            // 
            salaryInput.Location = new Point(273, 57);
            salaryInput.Name = "salaryInput";
            salaryInput.Size = new Size(83, 23);
            salaryInput.TabIndex = 13;
            // 
            // RentInput
            // 
            RentInput.Location = new Point(273, 90);
            RentInput.Name = "RentInput";
            RentInput.Size = new Size(83, 23);
            RentInput.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RentInput);
            Controls.Add(salaryInput);
            Controls.Add(coupleInput);
            Controls.Add(ageInput);
            Controls.Add(SupportInput);
            Controls.Add(WragInput);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private CheckBox WragInput;
        private CheckBox SupportInput;
        private CheckBox ageInput;
        private CheckBox coupleInput;
        private TextBox salaryInput;
        private TextBox RentInput;
    }
}