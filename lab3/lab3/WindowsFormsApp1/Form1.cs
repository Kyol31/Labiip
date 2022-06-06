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

        //Открытие формы добавления статьи
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 btnRedactForm = new Form2(this);
            btnRedactForm.Show();
        }

        //Открытие формы редактирования статьи
        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 btnRedactForm = new Form2(this);
            btnRedactForm.Show();
        }

        //Удаление строки
        private void button3_Click_1(object sender, EventArgs e)
        {
            int index = mainTable.SelectedRows[0].Index;
            mainTable.Rows.RemoveAt(index);
        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void научнаяСтатьяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);
            form4.Show();
        }

        private void научнаяРаботаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(this);
            form5.Show();
        }

        private void местоРаботыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(this);
            form6.Show();
        }

        private void научнаяСтепеньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(this);
            form7.Show();
        }

        private void издательствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(this);
            form8.Show();
        }

        private void уДКToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9(this);
            form9.Show();
        }
    }
}
