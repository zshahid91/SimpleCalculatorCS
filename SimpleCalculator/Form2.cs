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
    public partial class Form2 : Form

    {
        private float number1, number2, ans;
        private bool EqualButton_clicked = true;

        public Form2()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            if (EqualButton_clicked == true)
            {
                ans = number1 + number2;
                richTextBox1.Text = ans.ToString();
            }
        }

        private void num2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "2";
            number2 = 2;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "+";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        private void num1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "1";
            number1 = 1;
        }
    }
}
