using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency
{
    public partial class Form1 : Form
    {
        double[,] matrix = new double[3, 3] { {-0.4, 0.3, 0.1}, {0.4, -0.8, 0.4}, {0.1, 0.4, -0.5} };
        Random rnd = new Random();
        int i, totalHour, state = 0;
        double hour = 1, goodStates = 1, medStates = 0, badStates = 0;
        double[] p = { 0.38095, 0.30158, 0.31746 } ;
        double Average, AverageT, Variance, VarianceT, Chi;
        bool ChiTest;
        List<double> pointsY = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }
        private void btCalc_Click(object sender, EventArgs e)
        {
            totalHour = Int32.Parse(hoursOfWish.Value.ToString());
            /*i = 0;
            while (true)
            {
                matrix[i, 1] = rnd.NextDouble() % 1;
                matrix[i, 2] = rnd.NextDouble() % 1;
                if (matrix[i, 1] + matrix[i, 2] < 1)
                {
                    matrix[i, 0] = 0 - (matrix[i, 1] + matrix[i, 2]);
                    break;
                }
            }
            i++;
            while (true)
            {
                matrix[i, 0] = rnd.NextDouble() % 1;
                matrix[i, 2] = rnd.NextDouble() % 1;
                if (matrix[i, 0] + matrix[i, 2] < 1)
                {
                    matrix[i, 1] = 0 - (matrix[i, 0] + matrix[i, 2]);
                    break;
                }
            }
            i++;
            while (true)
            {
                matrix[i, 0] = rnd.NextDouble() % 1;
                matrix[i, 1] = rnd.NextDouble() % 1;
                if (matrix[i, 0] + matrix[i, 1] < 1)
                {
                    matrix[i, 2] = 0 - (matrix[i, 0] + matrix[i, 1]);
                    break;
                }
            }*/
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(0, state + 1);
            labelWthrGood.Text = "Распред. = " + (goodStates / hour);
            labelWthrMedium.Text = "Распред. = " + (medStates / hour);
            labelWthrBad.Text = "Распред. = " + (badStates / hour);
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            i = 0;
            double a = rnd.NextDouble() % 1;
            while (a >= 0)
            {
                if (i != state)
                {
                    a -= -1 * (matrix[state, i] / matrix[state, state]);
                    if (a <= 0)
                    {
                        if (i == 0)
                        {
                            goodStates++;
                        }
                        else if (i == 1)
                        {
                            medStates++;
                        }
                        else if (i == 2)
                        {
                            badStates++;
                        }
                        pointsY.Add(state + 1);
                        chart1.Series[0].Points.AddXY(hour, state + 1);
                        state = i;
                        break;
                    }
                }
                i = (i + 1) % 3;
            }
            hour++;
            hourCount.Text = "Hour: " + hour;
            Average = 0;
            double E = 0;
            for (int i = 0; i < 3; i++)
            {
                Average += matrix[i, state] * i;
                E += p[i] * i;
            }
            double AverageError = Math.Abs((Average - E) / E);
            Variance = 0;
            double D = 0;
            for (int i = 0; i < 3; i++)
            {
                Variance += matrix[i, state] * i * i;
                D += p[i] * i * i;
            }
            Variance -= Average * Average;
            D -= E * E;
            double VarianceError = Math.Abs((Variance - D) / D);

            Chi = 0;
            Chi += (goodStates - hour * p[0]) * (goodStates - hour * p[0]) / (hour * p[0]);
            Chi += (medStates - hour * p[1]) * (medStates - hour * p[1]) / (hour * p[1]);
            Chi += (badStates - hour * p[2]) * (badStates - hour * p[2]) / (hour * p[2]);
            if (Chi <= 6)
            {
                ChiTest = true;
            }
            else
            {
                ChiTest = false;
            }
            labelWthrGood.Text = "Распред. = " + (goodStates / hour);
            labelWthrMedium.Text = "Распред. = " + (medStates / hour);
            labelWthrBad.Text = "Распред. = " + (badStates / hour);
            labelWthrGoodIdeal.Text = "Соотн. с теор. идеал. Average = " + AverageError;
            labelWthrMediumIdeal.Text = "Соотн. с теор. идеал. Variable = " + VarianceError;
            labelWthrBadIdeal.Text = "Соотн. с теор. идеал. ChiSquare = " + Chi + ChiTest;
            if (hour == totalHour)
            {
                timer.Stop();
            }
        }
    }
}
