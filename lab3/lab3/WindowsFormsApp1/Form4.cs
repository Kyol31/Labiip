﻿using System;
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
    public partial class Form4 : Form
    {
        Form1 nw;
        public Form4(Form1 n)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(153, 180, 209);
            this.Width = 230;
            this.Height = 120;
            this.nw = n;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
