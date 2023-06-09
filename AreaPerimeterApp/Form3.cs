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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try // try catch block to ensure inputs are numbers
            {
                // converts triangles inputs into double
                double sideA = Convert.ToDouble(textBoxA.Text);
                double sideB = Convert.ToDouble(textBoxB.Text);
                double sideC = Convert.ToDouble(textBoxC.Text);

                // checks triangle validation - one side can't be bigger than the other two combined
                if (triangleValidation(sideA, sideB, sideC))
                {
                    double perimeter = sideA + sideB + sideC;
                    // heron's formula method for finding triangles area - needs half perimeter to find the area
                    double halfPerimeter = perimeter / 2;

                    double area = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
                    areaField.Text = $"Area:{area:F2}";
                    perimeterField.Text = $"Perimeter:{perimeter:F2}";
                }
                else // if triangle validation does not return true, message pops up for user to correct
                {
                    MessageBox.Show("The sum of any two sides must be greater than the third side, please change your input", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex) // catch tells user they have entered an incorrect number
            {
                MessageBox.Show("Enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool triangleValidation(double sideA, double sideB, double sideC) // function to validate that one side cant be bigger than the other two combined, 
        {
            return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
        }

        // on button click, current form is hidden and new form is displayed
        private void FormOneBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void FormTwoBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
