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
<<<<<<< HEAD
            string inputText = textBoxInput.Text.Trim();

            if (!string.IsNullOrEmpty(inputText))
            {
                labelOutput.Text = "Halo " + inputText;
            }
            else
            {
                labelOutput.Text = "Silakan masukkan nama!";
            }
=======
            labelOutput.Text = "Output: " + textBoxInput.Text;
>>>>>>> b3be9390960d9f9a54c57c5620ddc957c3b448d9
        }
    }
}

