using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_Q5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // num1 = textBox1.Text;
            //fact1 = 1;
            int i = 1;
            int f = 1;
            int num;
            num = Convert.ToInt32(textBox1.Text);
            for(i = 1; i <= num; i++)
            {
                f = f * i;
                textBox2.Text = f.ToString();
            }
        }
    }
}
