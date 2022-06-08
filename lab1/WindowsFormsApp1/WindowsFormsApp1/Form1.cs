using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Свойства и методы элемента управления Button";
            label2.Text = "1) Name-Имя элемента, по которому идет обращение в коде";
            label3.Text = "2) Text-Текст на кнопке";
            label4.Text = "3) Width, Heigth - Ширина и Высота кнопки";
            label5.Text = "4) ..";
            label6.Text = "Методы Button";
            label7.Text = "1) onCLICK - Событие при нажатии на кнопку";
            label8.Text = " ";
            label9.Text = " ";
            label10.Text = " ";
            label11.Text = "Кнопка которая вызывает событие ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "Свойства и методы элемента управления Label";
            label2.Text = "1) Name-Имя элемента, по которому идет обращение в коде";
            label3.Text = "2) Text-Изначальный текст";
            label4.Text = "3) Font-Стилизация текста";
            label5.Text = "4) ..";
            label6.Text = "Методы Label";
            label7.Text = "1) onCLICK - Вызывает событие Click";
            label8.Text = " ";
            label9.Text = " ";
            label10.Text = " ";
            label11.Text = "Предоставление описания для элемента управления";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Свойства и методы элемента управления ProgressBar";
            label2.Text = "1) maximum-максимальное возможное значение";
            label3.Text = "2) minimum-минимальное возможное значение";
            label4.Text = "3) value-текущее значение элемента";
            label5.Text = "4) Name - обращение по имени в коде";
            label6.Text = "Методы Label";
            label7.Text = "1) onCLICK - Вызывает событие Click";
            label8.Text = " ";
            label9.Text = " ";
            label10.Text = " ";
            label11.Text = "Элемент ProgressBar служит для того, чтобы дать пользователю информацию о ходе выполнения какой-либо задачи";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "1) BorderStyle - Границы";
            label3.Text = "2) BackColor -  Цвет границы";
            label4.Text = "3) Cursor - какой курсор будет при наведении";
            label5.Text = "4) Name - обращение по имени в коде";
            label6.Text = "Методы Panel";
            label7.Text = " ";
            label8.Text = " ";
            label9.Text = " ";
            label10.Text = " ";
            label11.Text = "Контейнер - объединяет элементы в группы";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Описание 1";
            label2.Text = "1) ";
            label3.Text = "2) ";
            label4.Text = "3) ";
            label5.Text = "4) ";
            label6.Text = "Описание 2";
            label7.Text = "1) ";
            label8.Text = "2) ";
            label9.Text = "3) ";
            label10.Text = "4) ";
            label11.Text = "Описание 3";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label12.Text = "Свойства и методы элемента управления RadioButton ";
            label13.Text = "1)Checked - поставлен ли флажок изначально ";
            label14.Text = "2)font - шрифт ";
            label15.Text = "3) Name - обращение по имени в коде";
            label16.Text = "Методы RadioButton ";
            label17.Text = "1)Унаследованные методы от control ";
            label18.Text = "2) ";
            label19.Text = "3) ";
            label20.Text = "Переключатель, который перекрывает другие переключатели в своем боксе ";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label12.Text = "Свойства и методы элемента управления GroupBox ";
            label13.Text = "1)Text - Текст заголовка ";
            label14.Text = "2)BackColor - цвет фона ";
            label15.Text = "3) Name - обращение по имени в коде";
            label16.Text = "Методы GroupBox ";
            label17.Text = "1) ";
            label18.Text = "2) ";
            label19.Text = "3) ";
            label20.Text = "Контейнер - ограниченный от формы границей";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label12.Text = "Свойства и методы элемента управления TabControl  ";
            label13.Text = "1)TabPages - колл-во вкладок ";
            label14.Text = "2)BackColor - Цвет фона ";
            label15.Text = "3) Name - обращение по имени в коде";
            label16.Text = "Методы TabControl ";
            label17.Text = "1) ";
            label18.Text = "2) ";
            label19.Text = "3) ";
            label20.Text = "Элемент контроля с несколькими вкладками, в которых храняться ЭУ";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label12.Text = "Свойства и методы CheckBox";
            }
            else 
            {
                label12.Text = "Описание 1";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                label13.Text = "1)Text - Текст флажка ";
                label14.Text = "2)CheckAlign - положение кнопки выбора";
                label15.Text = "3)Checked - вкл или выкл изначально";
            }
            else 
            {
                label13.Text = "1)";
                label14.Text = "2)";
                label15.Text = "3)";
            }
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                label16.Text = "Методы CheckBox";
                label17.Text = "1) Унаследованные методы от control";
                label18.Text = "2) ";
                label19.Text = "3) ";
            }
            else 
            {
                label16.Text = "Описание 2";
                label17.Text = "1) ";
                label18.Text = "2) ";
                label19.Text = "3) ";
            }
           

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                label20.Text = "Флажок для установки одного или более значений";
            }
            else
            {
                label20.Text = "Описание 3";
            }
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label12.Text = "Описание 1";
            label13.Text = "1)";
            label14.Text = "2)";
            label15.Text = "3)";
            label16.Text = "Описание 2";
            label17.Text = "1) ";
            label18.Text = "2) ";
            label19.Text = "3) ";
            label20.Text = "Описание 3";
        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label23.Text = textBox1.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label23.Text = " ";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(FBD.SelectedPath);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            textBox1.Text = fileText;
            MessageBox.Show("Файл открыт");
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, textBox1.Text);
            MessageBox.Show("Файл сохранен");
        }
        void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // 1000 миллисекунд
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
        }
    }
}
