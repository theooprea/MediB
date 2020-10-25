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
    public partial class Form7 : Form
    {
        public string current_token;
        public string data_appointment;
        public Form7(string chosendata, string token, string date)
        {
            InitializeComponent();
            current_token = token;
            int found = 0;
            found = date.IndexOf(" ");
            data_appointment = date.Substring(0, found);
            DataLabel.Text = "Data aleasa: " + data_appointment;
        }

        private void DataLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        // pt a face o programare
        private async void RegisterAppointmentButton_ClickAsync(object sender, EventArgs e)
        {
            // daca nu a fost completat vreun camp se afiseaza o eroare
            if ((textBox1.Text.Equals("") || textBox2.Text.Equals("") || domainUpDown1.Text.Equals("Selectati Ora")))
            {
                var confirmResult = MessageBox.Show("Nu au fost completate toate campurile!", "Eroare!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            // daca nu, se face un post request la server
            else
            {
                HttpClient client = new HttpClient();
                AddAppointment appointment = new AddAppointment();
                appointment.Specializare = textBox1.Text;
                appointment.CNP = textBox2.Text;
                appointment.DateTime = data_appointment + " " + domainUpDown1.Text;
                string url = "https://iulia.rms-it.ro/api/auth/getApp";
                // se formateaza contentul
                string content = String.Format("appointment={0}&specializare={1}&cnp={2}",
                    Uri.EscapeDataString(appointment.DateTime),
                    Uri.EscapeDataString(appointment.Specializare),
                    Uri.EscapeDataString(appointment.CNP));
                HttpContent cont = new StringContent(content, Encoding.UTF8, "application/x-www-form-urlencoded");
                // se pun headerele
                cont.Headers.Add("x-requested-with", "XMLHttpRequest");
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + current_token);
                HttpResponseMessage response = null;
                // se face requestul
                response = await client.PostAsync(url, cont);
                // daca a mers sau nu, se afiseaza un mesaj corespunzator
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Programarea a fost creata cu succes!", "Succes!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Programarea nu a fost creata cu succes!", "Fara Succes!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
