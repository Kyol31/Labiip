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
    public partial class Form6 : Form
    {
        Form1 nw;
        public Form6(Form1 n)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(153, 180, 209);
            this.Width = 230;
            this.Height = 120;
            this.nw = n;
        }
    }
}