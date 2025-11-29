using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS
{
    public partial class Calculator : Form
    {
        private string firstNumber = "";
        private string operation = "";
        private bool newInput = false;
        public Calculator()
        {
            InitializeComponent();
        }
        private void zero_Click(object sender, EventArgs e)
        {
            if (newInput) textBox1.Clear(); newInput = false;
            textBox1.Text += "0";
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (newInput) textBox1.Clear(); newInput = false;
            textBox1.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (newInput) textBox1.Clear(); newInput = false;
            textBox1.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (newInput) textBox1.Clear(); newInput = false;
            textBox1.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (newInput) textBox1.Clear(); newInput = false;
            textBox1.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (newInput) textBox1.Clear(); newInput = false;
            textBox1.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (newInput) textBox1.Clear(); newInput = false;
            textBox1.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (newInput) textBox1.Clear(); newInput = false;
            textBox1.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (newInput) textBox1.Clear(); newInput = false;
            textBox1.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (newInput) textBox1.Clear(); newInput = false;
            textBox1.Text += "9";
        }

        private void comma_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
                textBox1.Text += ",";
        }

        private void plus_Click(object sender, EventArgs e) 
        { 
            textBox1.Text += "+"; 
        }

        private void minus_Click(object sender, EventArgs e) 
        {
            textBox1.Text += "-"; 
        }

        private void multiply_Click(object sender, EventArgs e) 
        {
            textBox1.Text += "*"; 
        }

        private void Share_Click(object sender, EventArgs e) 
        { 
            textBox1.Text += "/"; 
        }

        private void procent_Click(object sender, EventArgs e)
        {
            firstNumber = textBox1.Text;
            operation = "%";
            newInput = true;
        }
        private void equally_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = textBox1.Text;

                expression = expression.Replace(",", ".");

                DataTable table = new DataTable();
                var result = table.Compute(expression, null);

                textBox1.Text = result.ToString().Replace(".", ",");
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в выражении! Проверьте знаки.");
                textBox1.Text = "Error";
            }
        }
        private void CE_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void deleteSymbol_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            firstNumber = "";
            operation = "";
        }
    }
}
