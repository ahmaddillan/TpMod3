using System;
using System.Windows.Forms;


namespace TpMod3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            labelOutput.Text = "Output: " + textBoxInput.Text;
        }
    }
}

