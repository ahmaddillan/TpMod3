namespace TpMod3
{
    partial class Form1
    {
        /// <summary>
        /// Variabel untuk desain form
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button button1;

        /// <summary>
        /// Membersihkan resource yang digunakan.
        /// </summary>
        /// <param name="disposing">True jika resource harus dibuang.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Inisialisasi komponen pada form
        /// </summary>
        private void InitializeComponent()
        {
            textBoxInput = new TextBox();
            labelOutput = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(12, 31);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(200, 23);
            textBoxInput.TabIndex = 0;
            // 
            // labelOutput
            // 
            labelOutput.Location = new Point(12, 73);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(200, 22);
            labelOutput.TabIndex = 1;
            labelOutput.Text = "Output: ";
            // 
            // button1
            // 
            button1.Location = new Point(218, 31);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(300, 200);
            Controls.Add(textBoxInput);
            Controls.Add(labelOutput);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form Input";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
