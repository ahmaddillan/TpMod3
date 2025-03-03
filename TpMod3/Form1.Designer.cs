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
<<<<<<< HEAD
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
=======
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();

            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(50, 30);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(200, 22);

            // 
            // labelOutput
            // 
            this.labelOutput.Location = new System.Drawing.Point(50, 100);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(200, 22);
            this.labelOutput.Text = "Output: ";

            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form Input";
>>>>>>> b3be9390960d9f9a54c57c5620ddc957c3b448d9
        }
    }
}
