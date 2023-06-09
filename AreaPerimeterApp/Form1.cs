namespace AreaPerimeterApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try //try-catch block to catch if wrong input put into textfield
            {
                double input = Convert.ToDouble(AnswerBox.Text); // converts input froms tring to double

                // calculates area and perimeter Values, then sets the label Field for each form
                double areaValue = Math.PI * Math.Pow(input, 2);
                AreaField.Text = $"Area:{areaValue:F2}";
                
                double perimeterValue = 2 * Math.PI * input;
                PerimeterField.Text = $"Perimeter:{perimeterValue:F2}";
            }
            catch (Exception ex) // if catch is caught, message box displays informing user to correct mistake 
            {
                MessageBox.Show("Enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // on button click, current form is hidden and new form is displayed
        private void FormTwoBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void FormThreeBtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}