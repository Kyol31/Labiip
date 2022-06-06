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
    public partial class Form2 : Form
    {
        Form1 newWindowRedact;
        public Form2(Form1 n)
        {
            InitializeComponent();
            this.newWindowRedact = n;
        }
        //Add new article
        private void button1_Click(object sender, EventArgs e)
        {
            newWindowRedact.mainTable.Rows.Add(text1.Text, text2.Text, text3.Text, text4.Text, text5.Text, text6.Text, text7.Text);
            this.Hide();
        }
        //redact article
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (text1.Text.Length > 0) {
               newWindowRedact.mainTable.SelectedRows[0].Cells[0].Value = text1.Text;
            }
            if (text2.Text.Length > 0)
            {
                newWindowRedact.mainTable.SelectedRows[0].Cells[1].Value = text2.Text;
            }
            if (text3.Text.Length > 0)
            {
                newWindowRedact.mainTable.SelectedRows[0].Cells[2].Value = text3.Text;
            }
            if (text4.Text.Length > 0)
            {
                newWindowRedact.mainTable.SelectedRows[0].Cells[3].Value = text4.Text;
            }
            if (text5.Text.Length > 0)
            {
                newWindowRedact.mainTable.SelectedRows[0].Cells[4].Value = text5.Text;
            }
            if (text6.Text.Length > 0)
            {
                newWindowRedact.mainTable.SelectedRows[0].Cells[5].Value = text6.Text;
            }
            if (text7.Text.Length > 0)
            {
                newWindowRedact.mainTable.SelectedRows[0].Cells[6].Value = text7.Text;
            }
            this.Hide();
        }
        //close form2
        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
