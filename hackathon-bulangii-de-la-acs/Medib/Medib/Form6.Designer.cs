namespace Medib
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChosenDataLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChosenDataLabel
            // 
            this.ChosenDataLabel.AutoSize = true;
            this.ChosenDataLabel.Location = new System.Drawing.Point(53, 33);
            this.ChosenDataLabel.Name = "ChosenDataLabel";
            this.ChosenDataLabel.Size = new System.Drawing.Size(46, 17);
            this.ChosenDataLabel.TabIndex = 0;
            this.ChosenDataLabel.Text = "label1";
            this.ChosenDataLabel.Click += new System.EventHandler(this.ChosenDataLabel_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(336, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Afiseaza programari";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 82);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(552, 237);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 355);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ChosenDataLabel);
            this.Name = "Form6";
            this.Text = "Programari curente";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChosenDataLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}