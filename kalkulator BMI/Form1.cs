using System.Numerics;

namespace kalkulator_BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar.Minimum = 16;
            progressBar.Maximum = 40;
        }
        double m2 = 0;
        double bmi = 0;

        

        private void oblicz_MouseClick(object sender, MouseEventArgs e)
        {
            if (double.TryParse(twzrost.Text, out double m))
            {
                if (double.TryParse(twaga.Text, out double kg))
                {
                    m2 = m * m;
                    bmi = kg / m2;

                    if (bmi < 16)
                    {
                        lwynik.Text = "Twoje BMI: " + bmi + " - wygłodzenie";
                        progressBar.Value = 16;
                    }
                    else if (bmi < 17)
                    {
                        lwynik.Text = "Twoje BMI: " + bmi + " - wychudzenie";
                        progressBar.Value = 17;
                    }
                    else if (bmi < 18.5)
                    {
                        lwynik.Text = "Twoje BMI: " + bmi + " - niedowaga";
                        progressBar.Value = 19;
                    }
                    else if (bmi < 25)
                    {
                        lwynik.Text = "Twoje BMI: " + bmi + " - norma";
                        progressBar.Value = 25;
                    }
                    else if (bmi < 30)
                    {
                        lwynik.Text = "Twoje BMI: " + bmi + " - nadwaga";
                        progressBar.Value = 30;
                    }
                    else if (bmi < 35)
                    {
                        lwynik.Text = "Twoje BMI: " + bmi + " - otyłość I stopnia";
                        progressBar.Value = 35;
                    }
                    else if (bmi < 40)
                    {
                        lwynik.Text = "Twoje BMI: " + bmi + " - otyłość II stopnia";
                        progressBar.Value = 37;
                    }
                    else if (bmi >= 40)
                    {
                        lwynik.Text = "Twoje BMI: " + bmi + " - otyłość III stopnia";
                        progressBar.Value = 40;
                    }
                }
                else
                {
                    lwynik.Text = "Błąd wagi";
                }
            }
            else
            {
                lwynik.Text = "Błąd wzrostu";
            }
        }
    }
}
