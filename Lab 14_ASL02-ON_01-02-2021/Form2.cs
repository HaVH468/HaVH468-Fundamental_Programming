using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_14_ASL02_ON_01_02_2021
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
            listBox1.Items.Add(sum);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sub = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
            listBox1.Items.Add(sub);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int mul = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
            listBox1.Items.Add(mul);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int div = int.Parse(textBox1.Text) / int.Parse(textBox2.Text);
            listBox1.Items.Add(div);
        }
    }
}
