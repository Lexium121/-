﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vigener
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shifr.ShifrForm.ShowForm();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Analyz.AnalyzForm.ShowForm();
        }
    }
}
