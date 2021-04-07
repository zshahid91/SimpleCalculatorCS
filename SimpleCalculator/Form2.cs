using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SimpleCalculator
{
    public partial class Form2 : Form

    {
        float number1, number2, ans = 0;
        List<float> numbers = new List<float>();
        int count = 0;
        private bool AddButton_clicked = false;

        public Form2()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= richTextBox1.TextLength;i++)
            {
                //if (AddButton_clicked == true)
                if (!(richTextBox1.isContains("+")))
                {
                    number1 = float.Parse(richTextBox1.Text);
                    ans = ans + number1;
                }
                //ans = ans + numbers[i];
                //richTextBox1.Text = ans.ToString();
                
            }
                
            richTextBox1.Text = ans.ToString();
        }

        private void num2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "2";
            numbers.Add(2);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "+";
            AddButton_clicked = true;
            count++;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "3";
            numbers.Add(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "4";
            numbers.Add(4);
        }

        private void num5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "5";
            numbers.Add(5);
        }

        private void num6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "6";
            numbers.Add(6);
        }

        private void num7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "7";
            numbers.Add(7);
        }

        private void num8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "8";
            numbers.Add(8);
        }

        private void num9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "9";
            numbers.Add(8);
        }

        private void doubleZerosBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "0";
            richTextBox1.Text += "0";
            numbers.Add(0);
            numbers.Add(0);
        }

        private void num0_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "0";
            numbers.Add(0);
        }

        private void clrButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            numbers.Clear();
            count = 0;
            ans = 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        private void num1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "1";
            numbers.Add(float.Parse(richTextBox1.Text));
        }
    }
}
