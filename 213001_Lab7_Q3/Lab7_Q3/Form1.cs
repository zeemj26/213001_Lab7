﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab7_Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button1.Text;
        }

        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{
        //    int num1;
        //   textBox1.Text = textBox1.Text + (num1 = textBox1.Text.Length) + textBox2.Text;

        //}

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button10.Text;
        }
        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{
        //    int num1;
        //    textBox1.Text = textBox1.Text + (num1 = textBox1.Text.Length) + textBox2.Text;

        //}

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text =  product(int.Parse(textBox1.Text)).ToString();
        }
        public int product(int m)
        {
            return m * m;
            
        }
    }
}
