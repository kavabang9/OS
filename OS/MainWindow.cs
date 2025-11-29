using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OS
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            
            InitializeComponent();
            panel2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CloseStartMenu_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void HelpAndSupport_Click(object sender, EventArgs e)
        {
            HelpAndSupport buttonHelpAndSupport = new HelpAndSupport();
            buttonHelpAndSupport.Show();
        }

        private void Calculator_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.Show();
        }

        private void Computer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В ходе разработки 🛠");
        }

        private void ControlPanel_Click(object sender, EventArgs e)
        {
            ControlPanel panel = new ControlPanel();
            panel.Show();
        }       
    }
}
