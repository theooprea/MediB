namespace Medib
{
    partial class Form7
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DataLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RegisterAppointmentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(451, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(168, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(451, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.Location = new System.Drawing.Point(55, 24);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(193, 17);
            this.DataLabel.TabIndex = 2;
            this.DataLabel.Text = "Introduceti datele programarii";
            this.DataLabel.Click += new System.EventHandler(this.DataLabel_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(55, 76);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(85, 17);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Specializare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "CNP Pacient";
            // 
            // RegisterAppointmentButton
            // 
            this.RegisterAppointmentButton.Location = new System.Drawing.Point(301, 231);
            this.RegisterAppointmentButton.Name = "RegisterAppointmentButton";
            this.RegisterAppointmentButton.Size = new System.Drawing.Size(119, 51);
            this.RegisterAppointmentButton.TabIndex = 5;
            this.RegisterAppointmentButton.Text = "Inregistrati Programarea";
            this.RegisterAppointmentButton.UseVisualStyleBackColor = true;
            this.RegisterAppointmentButton.Click += new System.EventHandler(this.RegisterAppointmentButton_ClickAsync);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ora";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("00:00");
            this.domainUpDown1.Items.Add("01:00");
            this.domainUpDown1.Items.Add("02:00");
            this.domainUpDown1.Items.Add("03:00");
            this.domainUpDown1.Items.Add("04:00");
            this.domainUpDown1.Items.Add("05:00");
            this.domainUpDown1.Items.Add("06:00");
            this.domainUpDown1.Items.Add("07:00");
            this.domainUpDown1.Items.Add("08:00");
            this.domainUpDown1.Items.Add("09:00");
            this.domainUpDown1.Items.Add("10:00");
            this.domainUpDown1.Items.Add("11:00");
            this.domainUpDown1.Items.Add("12:00");
            this.domainUpDown1.Items.Add("13:00");
            this.domainUpDown1.Items.Add("14:00");
            this.domainUpDown1.Items.Add("15:00");
            this.domainUpDown1.Items.Add("16:00");
            this.domainUpDown1.Items.Add("17:00");
            this.domainUpDown1.Items.Add("18:00");
            this.domainUpDown1.Items.Add("19:00");
            this.domainUpDown1.Items.Add("20:00");
            this.domainUpDown1.Items.Add("21:00");
            this.domainUpDown1.Items.Add("22:00");
            this.domainUpDown1.Items.Add("23:00");
            this.domainUpDown1.Location = new System.Drawing.Point(168, 144);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.ReadOnly = true;
            this.domainUpDown1.Size = new System.Drawing.Size(451, 22);
            this.domainUpDown1.TabIndex = 8;
            this.domainUpDown1.Text = "Selectati Ora";
            this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 325);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegisterAppointmentButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form7";
            this.Text = "Adaugare programare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RegisterAppointmentButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
    }
}