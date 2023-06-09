namespace AreaPerimeterApp
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
            AnswerBox = new TextBox();
            Submit = new Button();
            Radius = new Label();
            AreaField = new Label();
            PerimeterField = new Label();
            FormTwoBtn = new Button();
            FormThreeBtn = new Button();
            SuspendLayout();
            // 
            // AnswerBox
            // 
            AnswerBox.Location = new Point(252, 107);
            AnswerBox.Name = "AnswerBox";
            AnswerBox.Size = new Size(125, 27);
            AnswerBox.TabIndex = 0;
            // 
            // Submit
            // 
            Submit.Location = new Point(252, 187);
            Submit.Name = "Submit";
            Submit.Size = new Size(94, 29);
            Submit.TabIndex = 1;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // Radius
            // 
            Radius.AutoSize = true;
            Radius.Location = new Point(184, 110);
            Radius.Name = "Radius";
            Radius.Size = new Size(53, 20);
            Radius.TabIndex = 2;
            Radius.Text = "Radius";
            // 
            // AreaField
            // 
            AreaField.AutoSize = true;
            AreaField.Location = new Point(285, 305);
            AreaField.Name = "AreaField";
            AreaField.Size = new Size(43, 20);
            AreaField.TabIndex = 3;
            AreaField.Text = "Area:";
            // 
            // PerimeterField
            // 
            PerimeterField.AutoSize = true;
            PerimeterField.Location = new Point(285, 336);
            PerimeterField.Name = "PerimeterField";
            PerimeterField.Size = new Size(75, 20);
            PerimeterField.TabIndex = 4;
            PerimeterField.Text = "Perimeter:";
            // 
            // FormTwoBtn
            // 
            FormTwoBtn.Location = new Point(597, 40);
            FormTwoBtn.Name = "FormTwoBtn";
            FormTwoBtn.Size = new Size(84, 61);
            FormTwoBtn.TabIndex = 5;
            FormTwoBtn.Text = "RectangleForm";
            FormTwoBtn.UseVisualStyleBackColor = true;
            FormTwoBtn.Click += FormTwoBtn_Click;
            // 
            // FormThreeBtn
            // 
            FormThreeBtn.Location = new Point(597, 110);
            FormThreeBtn.Name = "FormThreeBtn";
            FormThreeBtn.Size = new Size(84, 52);
            FormThreeBtn.TabIndex = 6;
            FormThreeBtn.Text = "Triangle Form";
            FormThreeBtn.UseVisualStyleBackColor = true;
            FormThreeBtn.Click += FormThreeBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FormThreeBtn);
            Controls.Add(FormTwoBtn);
            Controls.Add(PerimeterField);
            Controls.Add(AreaField);
            Controls.Add(Radius);
            Controls.Add(Submit);
            Controls.Add(AnswerBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AnswerBox;
        private Button Submit;
        private Label Radius;
        private Label AreaField;
        private Label PerimeterField;
        private Button FormTwoBtn;
        private Button FormThreeBtn;
    }
}