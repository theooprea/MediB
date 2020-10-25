namespace Medib
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CreateNewPatientButton = new System.Windows.Forms.Button();
            this.LoggedInAsLabel = new System.Windows.Forms.Label();
            this.ProgramariButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduceti CNP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Logat ca si:";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(264, 286);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(289, 22);
            this.SearchBox.TabIndex = 3;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(645, 91);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(85, 34);
            this.LogoutButton.TabIndex = 4;
            this.LogoutButton.Text = "Delogare";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(264, 347);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(85, 54);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Cauta pacient";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CreateNewPatientButton
            // 
            this.CreateNewPatientButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CreateNewPatientButton.Location = new System.Drawing.Point(452, 347);
            this.CreateNewPatientButton.Name = "CreateNewPatientButton";
            this.CreateNewPatientButton.Size = new System.Drawing.Size(101, 54);
            this.CreateNewPatientButton.TabIndex = 6;
            this.CreateNewPatientButton.Text = "Creeaza nou pacient";
            this.CreateNewPatientButton.UseVisualStyleBackColor = true;
            this.CreateNewPatientButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LoggedInAsLabel
            // 
            this.LoggedInAsLabel.AutoSize = true;
            this.LoggedInAsLabel.Location = new System.Drawing.Point(654, 43);
            this.LoggedInAsLabel.Name = "LoggedInAsLabel";
            this.LoggedInAsLabel.Size = new System.Drawing.Size(91, 17);
            this.LoggedInAsLabel.TabIndex = 7;
            this.LoggedInAsLabel.Text = "Doctor Name";
            // 
            // ProgramariButton
            // 
            this.ProgramariButton.Location = new System.Drawing.Point(69, 86);
            this.ProgramariButton.Name = "ProgramariButton";
            this.ProgramariButton.Size = new System.Drawing.Size(107, 45);
            this.ProgramariButton.TabIndex = 9;
            this.ProgramariButton.Text = "Programari";
            this.ProgramariButton.UseVisualStyleBackColor = true;
            this.ProgramariButton.Click += new System.EventHandler(this.ProgramariButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pentru progrmari accesati:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProgramariButton);
            this.Controls.Add(this.LoggedInAsLabel);
            this.Controls.Add(this.CreateNewPatientButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Search/Add patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button CreateNewPatientButton;
        private System.Windows.Forms.Label LoggedInAsLabel;
        private System.Windows.Forms.Button ProgramariButton;
        private System.Windows.Forms.Label label3;
    }
}