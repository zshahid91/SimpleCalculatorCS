using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1, num2, ans;
            num1 = float.Parse(textBox1.Text);
            num2 = float.Parse(textBox2.Text);
            ans = num1 + num2;
            textBox3.Text = ans.ToString();
        }

        private void DivButton_Click(object sender, EventArgs e)
        {
            float num1, num2, ans;
            num1 = float.Parse(textBox1.Text);
            num2 = float.Parse(textBox2.Text);
            ans = num1 / num2;
            textBox3.Text = ans.ToString();
        }

        private void MulButton_Click(object sender, EventArgs e)
        {
            float num1, num2, ans;
            num1 = float.Parse(textBox1.Text);
            num2 = float.Parse(textBox2.Text);
            ans = num1 * num2;
            textBox3.Text = ans.ToString();
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            float num1, num2, ans;
            num1 = float.Parse(textBox1.Text);
            num2 = float.Parse(textBox2.Text);
            ans = num1 - num2;
            textBox3.Text = ans.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            float num1, num2, ans;
            num1 = float.Parse(textBox1.Text);
            num2 = float.Parse(textBox2.Text);
            ans = num1 % num2;
            textBox3.Text = ans.ToString();
        }
    }
}
