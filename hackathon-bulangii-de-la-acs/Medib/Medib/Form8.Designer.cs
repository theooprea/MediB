namespace Medib
{
    partial class Form8
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.whenBox = new System.Windows.Forms.TextBox();
            this.doc_nameBox = new System.Windows.Forms.TextBox();
            this.infosBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduceti informatiile consultul:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data consultului (dd/mm/yyyy hh:mm):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nume si prenume cadru medical:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Comentarii referitoare la consult:";
            // 
            // whenBox
            // 
            this.whenBox.Location = new System.Drawing.Point(335, 123);
            this.whenBox.Name = "whenBox";
            this.whenBox.Size = new System.Drawing.Size(518, 22);
            this.whenBox.TabIndex = 4;
            // 
            // doc_nameBox
            // 
            this.doc_nameBox.Location = new System.Drawing.Point(335, 173);
            this.doc_nameBox.Name = "doc_nameBox";
            this.doc_nameBox.Size = new System.Drawing.Size(518, 22);
            this.doc_nameBox.TabIndex = 5;
            // 
            // infosBox
            // 
            this.infosBox.Location = new System.Drawing.Point(335, 217);
            this.infosBox.Multiline = true;
            this.infosBox.Name = "infosBox";
            this.infosBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infosBox.Size = new System.Drawing.Size(518, 61);
            this.infosBox.TabIndex = 6;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(335, 301);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(179, 66);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "AdaugaConsult";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 400);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.infosBox);
            this.Controls.Add(this.doc_nameBox);
            this.Controls.Add(this.whenBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox whenBox;
        private System.Windows.Forms.TextBox doc_nameBox;
        private System.Windows.Forms.TextBox infosBox;
        private System.Windows.Forms.Button AddButton;
    }
}