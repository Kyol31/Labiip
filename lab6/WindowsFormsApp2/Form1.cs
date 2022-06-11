using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "1";
            textBox2.Text = "1";
            textBox3.Text = "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = 0, y = 0;
            this.chart1.Series[0].Points.Clear();
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            double start = -9.9;
            double end = 10.1;
            double step = 0.1;
            this.chart1.Series[0].Points.Clear();
            x = start;
            while (x <= end)
            {
                if (radioButton1.Checked)
                {
                    y = x * a + b;
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x = x + step;
                }
                else if (radioButton2.Checked)
                {
                    y = a * Math.Sin(x * b) + c;
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x = x + step;
                }
                else if (radioButton3.Checked)
                {
                    y = a * Math.Cos(x * b + c);
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x = x + step;
                }
                else if (radioButton4.Checked)
                {
                    y = a * Math.Tan(x * b) + c;
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x = x + step;
                }
                else if (radioButton5.Checked)
                {
                    y = a * ((Math.Cos(x * b + c)) / (Math.Sin(x * b + c)));
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x = x + step;
                }
                else if (radioButton6.Checked)
                {
                    y = b * Math.Pow(x, a);
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x = x + step;
                }
                else if (radioButton7.Checked)
                {
                    y = Math.Pow(a, x + b);
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x = x + step;
                }
                else if (radioButton8.Checked)
                {
                    var t = (Math.Sin(x) + a * x) / ((x - Math.Sqrt(x)) - 1);
                    y = Math.Pow(t, b / x);
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x = x + step;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.chart1.Series[0].Points.Clear();
            textBox1.Text = "1";
            textBox2.Text = "1";
            textBox3.Text = "1";
        }
    }
}
