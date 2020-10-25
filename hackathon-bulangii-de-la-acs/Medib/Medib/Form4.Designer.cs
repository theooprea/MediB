namespace Medib
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.OtherPacientButton = new System.Windows.Forms.Button();
            this.PersonalDataButton = new System.Windows.Forms.Button();
            this.MedicalHistoryButton = new System.Windows.Forms.Button();
            this.ImagingButton = new System.Windows.Forms.Button();
            this.ReteteButton = new System.Windows.Forms.Button();
            this.ConsultsButton = new System.Windows.Forms.Button();
            this.ContentBox = new System.Windows.Forms.TextBox();
            this.PatientNameLabel = new System.Windows.Forms.Label();
            this.DetailLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.BileteDeTrimitereButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(786, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CNP pacient:";
            // 
            // OtherPacientButton
            // 
            this.OtherPacientButton.Image = ((System.Drawing.Image)(resources.GetObject("OtherPacientButton.Image")));
            this.OtherPacientButton.Location = new System.Drawing.Point(30, 16);
            this.OtherPacientButton.Name = "OtherPacientButton";
            this.OtherPacientButton.Size = new System.Drawing.Size(96, 69);
            this.OtherPacientButton.TabIndex = 2;
            this.OtherPacientButton.UseVisualStyleBackColor = true;
            this.OtherPacientButton.Click += new System.EventHandler(this.OtherPacientButton_Click);
            // 
            // PersonalDataButton
            // 
            this.PersonalDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalDataButton.Location = new System.Drawing.Point(30, 199);
            this.PersonalDataButton.Name = "PersonalDataButton";
            this.PersonalDataButton.Size = new System.Drawing.Size(194, 71);
            this.PersonalDataButton.TabIndex = 3;
            this.PersonalDataButton.Text = "Date personale";
            this.PersonalDataButton.UseVisualStyleBackColor = true;
            this.PersonalDataButton.Click += new System.EventHandler(this.PersonalDataButton_Click);
            // 
            // MedicalHistoryButton
            // 
            this.MedicalHistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicalHistoryButton.Location = new System.Drawing.Point(30, 584);
            this.MedicalHistoryButton.Name = "MedicalHistoryButton";
            this.MedicalHistoryButton.Size = new System.Drawing.Size(194, 71);
            this.MedicalHistoryButton.TabIndex = 4;
            this.MedicalHistoryButton.Text = "Istoric analize";
            this.MedicalHistoryButton.UseVisualStyleBackColor = true;
            this.MedicalHistoryButton.Click += new System.EventHandler(this.MedicalHistoryButton_Click);
            // 
            // ImagingButton
            // 
            this.ImagingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImagingButton.Location = new System.Drawing.Point(30, 507);
            this.ImagingButton.Name = "ImagingButton";
            this.ImagingButton.Size = new System.Drawing.Size(194, 71);
            this.ImagingButton.TabIndex = 5;
            this.ImagingButton.Text = "Imagistica";
            this.ImagingButton.UseVisualStyleBackColor = true;
            this.ImagingButton.Click += new System.EventHandler(this.ImagingButton_Click);
            // 
            // ReteteButton
            // 
            this.ReteteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReteteButton.Location = new System.Drawing.Point(30, 353);
            this.ReteteButton.Name = "ReteteButton";
            this.ReteteButton.Size = new System.Drawing.Size(194, 71);
            this.ReteteButton.TabIndex = 6;
            this.ReteteButton.Text = "Retete";
            this.ReteteButton.UseVisualStyleBackColor = true;
            this.ReteteButton.Click += new System.EventHandler(this.ReteteButton_Click);
            // 
            // ConsultsButton
            // 
            this.ConsultsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultsButton.Location = new System.Drawing.Point(30, 276);
            this.ConsultsButton.Name = "ConsultsButton";
            this.ConsultsButton.Size = new System.Drawing.Size(194, 71);
            this.ConsultsButton.TabIndex = 7;
            this.ConsultsButton.Text = "Consulturi";
            this.ConsultsButton.UseVisualStyleBackColor = true;
            this.ConsultsButton.Click += new System.EventHandler(this.ConsultsButton_Click);
            // 
            // ContentBox
            // 
            this.ContentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContentBox.Location = new System.Drawing.Point(280, 199);
            this.ContentBox.Multiline = true;
            this.ContentBox.Name = "ContentBox";
            this.ContentBox.ReadOnly = true;
            this.ContentBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ContentBox.Size = new System.Drawing.Size(1008, 456);
            this.ContentBox.TabIndex = 9;
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.AutoSize = true;
            this.PatientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameLabel.Location = new System.Drawing.Point(920, 36);
            this.PatientNameLabel.Name = "PatientNameLabel";
            this.PatientNameLabel.Size = new System.Drawing.Size(124, 25);
            this.PatientNameLabel.TabIndex = 11;
            this.PatientNameLabel.Text = "Pacient CNP";
            // 
            // DetailLabel
            // 
            this.DetailLabel.AutoSize = true;
            this.DetailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailLabel.Location = new System.Drawing.Point(275, 137);
            this.DetailLabel.Name = "DetailLabel";
            this.DetailLabel.Size = new System.Drawing.Size(118, 25);
            this.DetailLabel.TabIndex = 12;
            this.DetailLabel.Text = "Detail Name";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(617, 691);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(200, 68);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "AddEntry";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // BileteDeTrimitereButton
            // 
            this.BileteDeTrimitereButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BileteDeTrimitereButton.Location = new System.Drawing.Point(30, 430);
            this.BileteDeTrimitereButton.Name = "BileteDeTrimitereButton";
            this.BileteDeTrimitereButton.Size = new System.Drawing.Size(194, 71);
            this.BileteDeTrimitereButton.TabIndex = 15;
            this.BileteDeTrimitereButton.Text = "Bilete de trimitere";
            this.BileteDeTrimitereButton.UseVisualStyleBackColor = true;
            this.BileteDeTrimitereButton.Click += new System.EventHandler(this.BileteDeTrimitereButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 807);
            this.Controls.Add(this.BileteDeTrimitereButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DetailLabel);
            this.Controls.Add(this.PatientNameLabel);
            this.Controls.Add(this.ContentBox);
            this.Controls.Add(this.ConsultsButton);
            this.Controls.Add(this.ReteteButton);
            this.Controls.Add(this.ImagingButton);
            this.Controls.Add(this.MedicalHistoryButton);
            this.Controls.Add(this.PersonalDataButton);
            this.Controls.Add(this.OtherPacientButton);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Patient menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OtherPacientButton;
        private System.Windows.Forms.Button PersonalDataButton;
        private System.Windows.Forms.Button MedicalHistoryButton;
        private System.Windows.Forms.Button ImagingButton;
        private System.Windows.Forms.Button ReteteButton;
        private System.Windows.Forms.Button ConsultsButton;
        private System.Windows.Forms.TextBox ContentBox;
        private System.Windows.Forms.Label PatientNameLabel;
        private System.Windows.Forms.Label DetailLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button BileteDeTrimitereButton;
    }
}