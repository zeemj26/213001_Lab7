﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_Q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //(F-32)*5/9.
            double c = 0.0, f = 0.0;
            f = Convert.ToDouble(textBox1.Text);
            c = (5.0/9 ) * (f-32);
            textBox2.Text = c.ToString(); 
        }
    }
}
