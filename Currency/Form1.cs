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
        double p1, p2, p3;
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
            p1 = 1 / (((1 - matrix[2, 2]) * matrix[0, 1] + matrix[2,1] * matrix[0,2] + (1 - matrix[1,1]) * matrix[0,2] + matrix[1,2] * matrix[0,1]) / ((1 - matrix[2,2]) * (1 - matrix[1,1]) - matrix[1,2] * matrix[2,1]) + 1);
            p2 = ((1 - matrix[2,2]) * matrix[0,1] * p1 + matrix[2,1] * matrix[0,2] * p1) / ((1 - matrix[2,2]) * (1 - matrix[1,1]) - matrix[1,2] * matrix[2,1]);
            p3 = ((1 - matrix[1,1]) * matrix[0,2] * p1 + matrix[1,2] * matrix[0,1] * p1) / ((1 - matrix[2,2]) * (1 - matrix[1,1]) - matrix[1,2] * matrix[2,1]);
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(0, state + 1);
            labelWthrGood.Text = "Распред. = " + (goodStates / hour);
            labelWthrMedium.Text = "Распред. = " + (medStates / hour);
            labelWthrBad.Text = "Распред. = " + (badStates / hour);
            labelWthrGoodIdeal.Text = "Теор. идеал. = " + p1;
            labelWthrMediumIdeal.Text = "Теор. идеал. = " + p2;
            labelWthrBadIdeal.Text = "Теор. идеал. = " + p3;
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
            labelWthrGood.Text = "Распред. = " + (goodStates / hour);
            labelWthrMedium.Text = "Распред. = " + (medStates / hour);
            labelWthrBad.Text = "Распред. = " + (badStates / hour);
            labelWthrGoodIdeal.Text = "Соотн. с теор. идеал. = " + p1;
            labelWthrMediumIdeal.Text = "Соотн. с теор. идеал. = " + p2;
            labelWthrBadIdeal.Text = "Соотн. с теор. идеал. = " + p3;
            if (hour == totalHour)
            {
                timer.Stop();
            }
        }
    }
}
