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
            SubmitButton = new Button();
            label1 = new Label();
            label2 = new Label();
            WragInput = new CheckBox();
            SupportInput = new CheckBox();
            ageInput = new CheckBox();
            coupleInput = new CheckBox();
            salaryInput = new TextBox();
            RentInput = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            DOBPicker = new DateTimePicker();
            label3 = new Label();
            childName = new TextBox();
            AddChildButton = new Button();
            ChildrenAddedLabel = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 251);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(776, 167);
            textBox1.TabIndex = 0;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(298, 211);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(83, 23);
            SubmitButton.TabIndex = 1;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 41);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Net Salary";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 70);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 3;
            label2.Text = "Rent Amount";
            // 
            // WragInput
            // 
            WragInput.AutoSize = true;
            WragInput.Location = new Point(57, 95);
            WragInput.Name = "WragInput";
            WragInput.Size = new Size(229, 19);
            WragInput.TabIndex = 9;
            WragInput.Text = "WRAG continuous since 2nd april 2017";
            WragInput.UseVisualStyleBackColor = true;
            // 
            // SupportInput
            // 
            SupportInput.AutoSize = true;
            SupportInput.Location = new Point(452, 95);
            SupportInput.Name = "SupportInput";
            SupportInput.Size = new Size(68, 19);
            SupportInput.TabIndex = 10;
            SupportInput.Text = "Support";
            SupportInput.UseVisualStyleBackColor = true;
            // 
            // ageInput
            // 
            ageInput.AutoSize = true;
            ageInput.Location = new Point(57, 131);
            ageInput.Name = "ageInput";
            ageInput.Size = new Size(66, 19);
            ageInput.TabIndex = 11;
            ageInput.Text = "Over 18";
            ageInput.UseVisualStyleBackColor = true;
            // 
            // coupleInput
            // 
            coupleInput.AutoSize = true;
            coupleInput.Location = new Point(452, 131);
            coupleInput.Name = "coupleInput";
            coupleInput.Size = new Size(90, 19);
            coupleInput.TabIndex = 12;
            coupleInput.Text = "Couple Rate";
            coupleInput.UseVisualStyleBackColor = true;
            // 
            // salaryInput
            // 
            salaryInput.Location = new Point(273, 41);
            salaryInput.Name = "salaryInput";
            salaryInput.Size = new Size(83, 23);
            salaryInput.TabIndex = 13;
            salaryInput.Text = "0";
            // 
            // RentInput
            // 
            RentInput.Location = new Point(273, 70);
            RentInput.Name = "RentInput";
            RentInput.Size = new Size(83, 23);
            RentInput.TabIndex = 14;
            RentInput.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(452, 44);
            label8.Name = "label8";
            label8.Size = new Size(86, 15);
            label8.TabIndex = 15;
            label8.Text = "if none, enter 0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(452, 69);
            label9.Name = "label9";
            label9.Size = new Size(86, 15);
            label9.TabIndex = 16;
            label9.Text = "if none, enter 0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(273, 9);
            label11.Name = "label11";
            label11.Size = new Size(129, 15);
            label11.TabIndex = 18;
            label11.Text = "UC eligibility calculator";
            // 
            // DOBPicker
            // 
            DOBPicker.Location = new Point(247, 164);
            DOBPicker.Name = "DOBPicker";
            DOBPicker.Size = new Size(200, 23);
            DOBPicker.TabIndex = 19;
            DOBPicker.ValueChanged += DOBPicker_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 164);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 20;
            label3.Text = "Add Children";
            // 
            // childName
            // 
            childName.Location = new Point(141, 161);
            childName.Name = "childName";
            childName.Size = new Size(100, 23);
            childName.TabIndex = 21;
            childName.Text = "name";
            // 
            // AddChildButton
            // 
            AddChildButton.Location = new Point(453, 164);
            AddChildButton.Name = "AddChildButton";
            AddChildButton.Size = new Size(96, 26);
            AddChildButton.TabIndex = 22;
            AddChildButton.Text = "Click to Add";
            AddChildButton.UseVisualStyleBackColor = true;
            AddChildButton.Click += AddChildButton_Click;
            // 
            // ChildrenAddedLabel
            // 
            ChildrenAddedLabel.AutoSize = true;
            ChildrenAddedLabel.Location = new Point(567, 170);
            ChildrenAddedLabel.Name = "ChildrenAddedLabel";
            ChildrenAddedLabel.Size = new Size(95, 15);
            ChildrenAddedLabel.TabIndex = 23;
            ChildrenAddedLabel.Text = "0 children added";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ChildrenAddedLabel);
            Controls.Add(AddChildButton);
            Controls.Add(childName);
            Controls.Add(label3);
            Controls.Add(DOBPicker);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(RentInput);
            Controls.Add(salaryInput);
            Controls.Add(coupleInput);
            Controls.Add(ageInput);
            Controls.Add(SupportInput);
            Controls.Add(WragInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SubmitButton);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button SubmitButton;
        private Label label1;
        private Label label2;
        private CheckBox WragInput;
        private CheckBox SupportInput;
        private CheckBox ageInput;
        private CheckBox coupleInput;
        private TextBox salaryInput;
        private TextBox RentInput;
        private Label label8;
        private Label label9;
        private Label label11;
        private DateTimePicker DOBPicker;
        private Label label3;
        private TextBox childName;
        private Button AddChildButton;
        private Label ChildrenAddedLabel;
    }
}