using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaPerimeterApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            try  // try catch block to catch any input that's not a number
            {
                double height = Convert.ToDouble(heightInput.Text);// converts height and width into double format
                double width = Convert.ToDouble(heightInput.Text);

                // calculates area and perimeter, then sets the label fields text to be displayed on the form to the values.
                double areaValue = height * width;
                areaField.Text = $"Area:{areaValue:F2}";
                
                double perimeterValue = 2 * height + 2 * width;
                perimeterField.Text = $"Perimeter:{perimeterValue:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // on button click, current form is hidden and new form is displayed
        private void FormOneBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void FormThreeBTN_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
