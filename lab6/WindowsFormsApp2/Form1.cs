using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            textBox4.Text = "0";
            textBox5.Text = "10";
            textBox6.Text = "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y;
            this.chart1.Series[0].Points.Clear();
            var a = Convert.ToInt32(textBox1.Text);
            var b = Convert.ToInt32(textBox2.Text);
            var c = Convert.ToInt32(textBox3.Text);
            var start = Convert.ToInt32(textBox4.Text);
            var end = Convert.ToInt32(textBox5.Text);
            var step = Convert.ToInt32(textBox6.Text);
            if (radioButton1.Checked)
            {
                c = 0;
                x = start;
                while (x <= end) 
                {
                    y = x * a + b;
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x = x + step;
                }
            }
            if (radioButton2.Checked)
            {
                x = start;
                while (x <= end)
                {
                    y = a * Math.Sin(x*b) + c;
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x = x + step;
                }
            }
            if (radioButton3.Checked)
            {
                x = start;
                while (x <= end)
                {
                    y = a * Math.Cos(x * b + c);
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x = x + step;
                }
            }
            if (radioButton4.Checked)
            {
                x = start;
                while (x <= end)
                {
                    y = a * Math.Tan(x * b) + c;
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x = x + step;
                }
            }
            if (radioButton5.Checked)
            {
                x = start;
                while (x <= end)
                {
                    y = a * (1/Math.Tan(x * b + c));
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x = x + step;
                }
            }
            if (radioButton6.Checked)
            {
                c = 0;
                x = start;
                while (x <= end)
                {
                    y = b * Math.Pow(x, a);
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x = x + step;
                }
            }
            if (radioButton7.Checked)
            {
                c = 0;
                x = start;
                while (x <= end)
                {
                    y = Math.Pow(a, x + b);
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x = x + step;
                }
            }
            if (radioButton8.Checked)
            {
                c = 0;
                x = start;
                while (x <= end)
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
            textBox4.Text = "0";
            textBox5.Text = "10";
            textBox6.Text = "1";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
