using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.OCR;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.Util;



namespace lab5
{
    public partial class Form1 : Form
    {
        private string filePath = string.Empty;
        private string lang = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(filePath);
            }
            else
            {
                MessageBox.Show("Картинка не выбрана!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(filePath) || String.IsNullOrWhiteSpace(filePath))
                {
                    throw new Exception("Картинка не выбрана!");
                }
                else if (comboBox1.SelectedItem == null)
                {
                    throw new Exception("Язык не выбран!");
                }
                else
                {
                    Tesseract tesseract = new Tesseract(@"./tessdata", lang, OcrEngineMode.TesseractLstmCombined);
                    tesseract.SetImage(new Image<Bgr, byte>(filePath));
                    tesseract.Recognize();
                    richTextBox1.Text = tesseract.GetUTF8Text();
                    tesseract.Dispose();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                lang = "rus";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                lang = "eng";
            }
        }
    }
}
