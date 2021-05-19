using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Globalization;

namespace LoopProblems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* COUNTER CONTROLLED REPETITION PROBLEMS:
         * 1. Create a program which will produce the following output:
         * 1 steamboat
         * 2 steamboat
         * 3 steamboat
         * CHARGE !
        */
        private void BtnPrintSteamBoat_Click(object sender, EventArgs e)
        {
            TxtAnswers.Text = "";

            for (int i = 1; i < 4; i++)
            {
                TxtAnswers.Text += i + " steamboat" + Environment.NewLine;
            }

            TxtAnswers.Text += "CHARGE!";
        }

        /*
         * 2. Create a program which will produce a table showing litre to gallons conversions for 20
         * to 60 litres in increments of 4 litres. (1 gal = 4.545985 litres)
        */
        private void BtnLitresToGallons_Click(object sender, EventArgs e)
        {
            TxtAnswers.Text = "";

            int gallon;
            double litre = 4.545985f;
            double conversion = 1;

            TxtAnswers.Text += "Gallons" + "\t" + "Litres" + Environment.NewLine;

            for (int i = 20; i <= 60; i += 4)
            {
                gallon = i;
                conversion = litre * gallon;
                TxtAnswers.Text += gallon.ToString() + "\t" + Math.Round(conversion, 2).ToString() + Environment.NewLine; ;
            }
        }

        /* USER CONTROLLED REPETITION PROBLEMS:
         * 1. Create a program which repeatedly prompts the user to enter miles and then outputs the
         * equivalent measurement in kilometres. Make sure the miles entered are positive. Recall
         * that 1 mile is equivalent to 1.61 kilometres.
        */
        private void BtnMilesToKilometres_Click(object sender, EventArgs e)
        {
            float miles = 0;
            float kilometres;
            const float conversion = 1.61f;
            
            while (true)
            {
                try
                {
                    miles = float.Parse(Interaction.InputBox("Enter the amount of Miles", "Miles to Kilometres", "", 200, 200), CultureInfo.InvariantCulture);

                    if (miles < 0)
                    {
                        miles *= -1;
                        MessageBox.Show("Converted Negative Value to Positive");
                    }

                    kilometres = miles * conversion;

                    MessageBox.Show(kilometres + "kms  in " + miles + " miles");

                    string response = Interaction.InputBox("Any more entries y/n", "Converter", "", 200, 200);
                    if (response == "n")
                        break;
                }
                catch (Exception)
                {
                    break;
                }
            }
        }

        /*
         * 2. Write a program which repeatedly prompts the user to enter a length and width and then
         * outputs the area. Challenge: Try to check for invalid length and width entries.
        */
        private void BtnAreaCalculator_Click(object sender, EventArgs e)
        {
            float length = 0;
            float width = 0;
            float area;
            
            while (true)
            {
                try
                {
                    if (length < 0)
                    {
                        length *= -1;
                        MessageBox.Show("Converted Negative Value to Positive");
                    }

                    if (width < 0)
                    {
                        width *= -1;
                        MessageBox.Show("Converted Negative Value to Positive");
                    }

                    length = float.Parse(Interaction.InputBox("Enter the Length", "Area Calculator", "", 200, 200), CultureInfo.InvariantCulture);
                    width = float.Parse(Interaction.InputBox("Enter the Width", "Area Calculator", "", 200, 200), CultureInfo.InvariantCulture);

                    area = length * width;

                    MessageBox.Show("The Area of " + length + " and " + width + ": " + Math.Round(area, 2));

                    string response = Interaction.InputBox("Any more entries y/n", "Converter", "", 200, 200);
                    if (response == "n")
                        break;

                }
                catch (Exception)
                {
                    break;
                }
            }
        }

        /*
         * 3. Write a program which repeatedly accepts a mark and then determines the letter grade to
         * assign it. Letter grades are assigned as follows.
         * 0 <= mark < 50 F
         * 50 <= mark < 60 D
         * 60 <= mark < 70 C
         * 70 <= mark < 80 B
         * 80 <= mark < 100 A 
        */
        private void BtnGradeCalculator_Click(object sender, EventArgs e)
        {
            float mark;

            while (true)
            {
                try
                {
                    mark = float.Parse(Interaction.InputBox("Enter in mark", "Grade Calculator", "", 200, 200), CultureInfo.InvariantCulture);

                    if (mark < 50)
                        MessageBox.Show("Grade is: F");
                    else if (mark >= 50 && mark < 60)
                        MessageBox.Show("Grade is: D");
                    else if (mark >= 60 && mark < 70)
                        MessageBox.Show("Grade is: C");
                    else if (mark >= 70 && mark < 80)
                        MessageBox.Show("Grade is: B");
                    else
                        MessageBox.Show("Grade is: A");

                    string response = Interaction.InputBox("Any more entries y/n", "Converter", "", 200, 200);
                    if (response == "n")
                        break;

                }
                catch (Exception)
                {
                    break;
                }
            }
        }

        /* FOR/NEXT PROBLEMS:
         * 1. Write a program which sums the numbers 1,2,3,...250
        */
        private void BtnSumTo250_Click(object sender, EventArgs e)
        {
            TxtAnswers.Text = "";

            int sum;

            TxtAnswers.Text += "Number:" + "\t" + "Sum:" + Environment.NewLine;

            for (int i = 1; i <= 250; i++)
            {
                sum = i + (i - 1);

                TxtAnswers.Text += i.ToString() + "\t" + "(" + i + " + "+ (i-1) + ") = " + sum.ToString() + Environment.NewLine;
            }
        }

        /*
         * 2. Write a program which sums all the odd numbers from 27 to 99
        */
        private void BtnOddNumbers29To99_Click(object sender, EventArgs e)
        {
            TxtAnswers.Text = "";
            
            int sum;

            TxtAnswers.Text += "Number:" + "\t" + "Sum:" + Environment.NewLine;

            for (int i = 27; i <= 99; i += 2)
            {
                sum = i + (i - 2);

                TxtAnswers.Text += i.ToString() + "\t(" + i + " + " + (i - 2) + ") = " + sum.ToString() + Environment.NewLine;
            }
        }

        /*
         * 3. Write a program which find the sum of the squares of the numbers 4,9,14,19,...39
        */
        private void BtnSumOfSquares_Click(object sender, EventArgs e)
        {
            TxtAnswers.Text = "";

            double sum;

            TxtAnswers.Text += "Number:" + "\t" + "Sum of Square:" + Environment.NewLine;

            for (int i = 4; i <= 39; i++)
            {
                sum = Math.Sqrt(i) + Math.Sqrt(i - 2);

                TxtAnswers.Text += i.ToString() + "\t(" + Math.Round(Math.Sqrt(i), 2) + " + " + Math.Round(Math.Sqrt(i - 2), 2) + ") = " + Math.Round(sum, 2).ToString() + Environment.NewLine;
            }
        }

        /*
         * 4. A delivery service charges its customers based on the weight of the package and the
         * distance it must be shipped. It has divided the area it serves into zones. The company
         * calculates the charge using the equation
         * C = .75 + .03 x W x Z
         * Write a program that will print a table of charges for weights of 2,4,6,8 and 10 and zones
         * of 1, 2, and 3.
        */
        private void BtnWeightsPerZone_Click(object sender, EventArgs e)
        {
            TxtAnswers.Text = "";

            float weight = 0;
            float zone = 0;
            float charge;

            TxtAnswers.Text += "Weights:\tZone:\tCharge:" + Environment.NewLine;

            for (int i = 2; i <= 10; i+= 2)
            {
                for (int j = 1; j <= 3 ; j++)
                {
                    weight = i;
                    zone = j;
                    charge = 0.75f + 0.3f * weight * zone;

                    TxtAnswers.Text += i.ToString() + "\t" + j.ToString() + "\t" + charge + Environment.NewLine;
                }
            }
        }

    }
}
