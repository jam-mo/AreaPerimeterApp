namespace AreaPerimeterApp
{
    partial class Form3
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
            labelA = new Label();
            labelB = new Label();
            labelC = new Label();
            areaField = new Label();
            perimeterField = new Label();
            Submit = new Button();
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            textBoxC = new TextBox();
            FormOneBtn = new Button();
            FormTwoBtn = new Button();
            SuspendLayout();
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Location = new Point(131, 65);
            labelA.Name = "labelA";
            labelA.Size = new Size(22, 20);
            labelA.TabIndex = 0;
            labelA.Text = "A:";
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Location = new Point(131, 101);
            labelB.Name = "labelB";
            labelB.Size = new Size(21, 20);
            labelB.TabIndex = 1;
            labelB.Text = "B:";
            // 
            // labelC
            // 
            labelC.AutoSize = true;
            labelC.Location = new Point(131, 139);
            labelC.Name = "labelC";
            labelC.Size = new Size(21, 20);
            labelC.TabIndex = 2;
            labelC.Text = "C:";
            // 
            // areaField
            // 
            areaField.AutoSize = true;
            areaField.Location = new Point(191, 327);
            areaField.Name = "areaField";
            areaField.Size = new Size(40, 20);
            areaField.TabIndex = 3;
            areaField.Text = "Area";
            // 
            // perimeterField
            // 
            perimeterField.AutoSize = true;
            perimeterField.Location = new Point(185, 362);
            perimeterField.Name = "perimeterField";
            perimeterField.Size = new Size(72, 20);
            perimeterField.TabIndex = 4;
            perimeterField.Text = "Perimeter";
            // 
            // Submit
            // 
            Submit.Location = new Point(216, 242);
            Submit.Name = "Submit";
            Submit.Size = new Size(104, 35);
            Submit.TabIndex = 5;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(159, 65);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(111, 27);
            textBoxA.TabIndex = 6;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(159, 98);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(111, 27);
            textBoxB.TabIndex = 7;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(159, 139);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(111, 27);
            textBoxC.TabIndex = 8;
            // 
            // FormOneBtn
            // 
            FormOneBtn.Location = new Point(639, 59);
            FormOneBtn.Name = "FormOneBtn";
            FormOneBtn.Size = new Size(94, 62);
            FormOneBtn.TabIndex = 9;
            FormOneBtn.Text = "Circle Button";
            FormOneBtn.UseVisualStyleBackColor = true;
            FormOneBtn.Click += FormOneBtn_Click;
            // 
            // FormTwoBtn
            // 
            FormTwoBtn.Location = new Point(639, 157);
            FormTwoBtn.Name = "FormTwoBtn";
            FormTwoBtn.Size = new Size(94, 64);
            FormTwoBtn.TabIndex = 10;
            FormTwoBtn.Text = "Rectangle Button";
            FormTwoBtn.UseVisualStyleBackColor = true;
            FormTwoBtn.Click += FormTwoBtn_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FormTwoBtn);
            Controls.Add(FormOneBtn);
            Controls.Add(textBoxC);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Controls.Add(Submit);
            Controls.Add(perimeterField);
            Controls.Add(areaField);
            Controls.Add(labelC);
            Controls.Add(labelB);
            Controls.Add(labelA);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelA;
        private Label labelB;
        private Label labelC;
        private Label areaField;
        private Label perimeterField;
        private Button Submit;
        private TextBox textBoxA;
        private TextBox textBoxB;
        private TextBox textBoxC;
        private Button FormOneBtn;
        private Button FormTwoBtn;
    }
}