using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace Medib
{
    public partial class Form5 : Form
    {
        public string doctor;
        public string current_token;
        public Form5(string username, string token)
        {
            InitializeComponent();
            doctor = username;
            current_token = token;
        }
        // se deschide un form6, de vizualizare a programarilor din ziua aleasa
        private void button1_Click(object sender, EventArgs e)
        {
            Form6 new_form6 = new Form6(Calendar.SelectionRange.Start.ToShortDateString(), current_token,
            Calendar.SelectionRange.Start.ToString());
            new_form6.Show();
        }
        // se deschideun form7, de adaugare a unei programari in ziua aleasa
        private void button2_Click(object sender, EventArgs e)
        {
            Calendar.MaxSelectionCount = 1;
            Form7 new_form7 = new Form7(Calendar.SelectionRange.Start.ToShortDateString(), current_token,
            Calendar.SelectionRange.Start.ToString());
            new_form7.Show();
        }
        // butonul de a ne intoarce la meniul doctorului
        private void BackButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Inchideti meniul de programari?", "Confirm Action",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (confirmResult == DialogResult.OK)
            {
                this.Hide();
                Form2 new_form2 = new Form2(doctor, current_token);
                new_form2.ShowDialog();
                this.Close();
            }
        }

        private void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
