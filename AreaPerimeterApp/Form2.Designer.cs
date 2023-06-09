namespace AreaPerimeterApp
{
    partial class Form2
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
            SubmitBtn = new Button();
            height = new Label();
            width = new Label();
            areaField = new Label();
            perimeterField = new Label();
            heightInput = new TextBox();
            widthInput = new TextBox();
            FormOneBtn = new Button();
            FormThreeBTN = new Button();
            SuspendLayout();
            // 
            // SubmitBtn
            // 
            SubmitBtn.Location = new Point(304, 241);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(94, 29);
            SubmitBtn.TabIndex = 0;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // height
            // 
            height.AutoSize = true;
            height.Location = new Point(202, 73);
            height.Name = "height";
            height.Size = new Size(51, 20);
            height.TabIndex = 1;
            height.Text = "height";
            // 
            // width
            // 
            width.AutoSize = true;
            width.Location = new Point(202, 104);
            width.Name = "width";
            width.Size = new Size(46, 20);
            width.TabIndex = 2;
            width.Text = "width";
            // 
            // areaField
            // 
            areaField.AutoSize = true;
            areaField.Location = new Point(310, 325);
            areaField.Name = "areaField";
            areaField.Size = new Size(40, 20);
            areaField.TabIndex = 3;
            areaField.Text = "Area";
            // 
            // perimeterField
            // 
            perimeterField.AutoSize = true;
            perimeterField.Location = new Point(310, 357);
            perimeterField.Name = "perimeterField";
            perimeterField.Size = new Size(72, 20);
            perimeterField.TabIndex = 4;
            perimeterField.Text = "Perimeter";
            // 
            // heightInput
            // 
            heightInput.Location = new Point(256, 75);
            heightInput.Name = "heightInput";
            heightInput.Size = new Size(125, 27);
            heightInput.TabIndex = 5;
            // 
            // widthInput
            // 
            widthInput.Location = new Point(256, 108);
            widthInput.Name = "widthInput";
            widthInput.Size = new Size(121, 27);
            widthInput.TabIndex = 6;
            // 
            // FormOneBtn
            // 
            FormOneBtn.Location = new Point(644, 57);
            FormOneBtn.Name = "FormOneBtn";
            FormOneBtn.Size = new Size(98, 57);
            FormOneBtn.TabIndex = 7;
            FormOneBtn.Text = "Circle Button";
            FormOneBtn.UseVisualStyleBackColor = true;
            FormOneBtn.Click += FormOneBtn_Click;
            // 
            // FormThreeBTN
            // 
            FormThreeBTN.Location = new Point(644, 130);
            FormThreeBTN.Name = "FormThreeBTN";
            FormThreeBTN.Size = new Size(94, 59);
            FormThreeBTN.TabIndex = 8;
            FormThreeBTN.Text = "Triangle Button";
            FormThreeBTN.UseVisualStyleBackColor = true;
            FormThreeBTN.Click += FormThreeBTN_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FormThreeBTN);
            Controls.Add(FormOneBtn);
            Controls.Add(widthInput);
            Controls.Add(heightInput);
            Controls.Add(perimeterField);
            Controls.Add(areaField);
            Controls.Add(width);
            Controls.Add(height);
            Controls.Add(SubmitBtn);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SubmitBtn;
        private Label height;
        private Label width;
        private Label areaField;
        private Label perimeterField;
        private TextBox heightInput;
        private TextBox widthInput;
        private Button FormOneBtn;
        private Button FormThreeBTN;
    }
}