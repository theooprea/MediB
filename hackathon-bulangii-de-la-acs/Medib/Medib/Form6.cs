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
using Newtonsoft.Json;

namespace Medib
{
    public partial class Form6 : Form
    {
        public string data_appointment;
        public string current_token;
        public Form6(string chosendata, string token, string date)
        {
            InitializeComponent();
            int found = 0;
            found = date.IndexOf(" ");
            data_appointment = date.Substring(0, found);
            ChosenDataLabel.Text = "Data aleasa: " + data_appointment;
            current_token = token;
        }

        private void ChosenDataLabel_Click(object sender, EventArgs e)
        {

        }
        // se face un Get Request pt a selecta toate programarile pentru ca apoi sa fie selectate doar cele din ziua selectata
        private async void button2_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            Appointment pacient = new Appointment();
            string url = "https://iulia.rms-it.ro/api/auth/getApp";
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + current_token);
            HttpResponseMessage response = null;
            response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                // datele sunt trecute intr-o lista ca apoi cand sunt comparate cu data selectata, data curenta e trecuta intr-o noua lista,
                // cea cu programarile din ziua data
                string encoded = await response.Content.ReadAsStringAsync();
                List<Appointment> decoded = JsonConvert.DeserializeObject<List<Appointment>>(encoded);
                List<Appointment> list = new List<Appointment>();
                for (var i = 0; i < decoded.Count; i++)
                {
                    int found = 0;
                    found = decoded[i].appointment.IndexOf(" ");
                    string data_app = decoded[i].appointment.Substring(0, found);
                    if (data_app.Equals(data_appointment))
                    {
                        list.Add(decoded[i]);
                    }
                }
                string afisare = "";
                // in lista finala, cea cu programarile din ziua respectiva se ordoneaza datele, apoi se afiseaza in formatul dat, prima data
                // datele sunt trecute in bufferul afisare, apoi in casuta de text
                var aux = list.OrderBy(p => p.appointment);
                foreach (var list_aux in aux)
                {
                    afisare = afisare + list_aux.specializare + "\r\n" + list_aux.appointment + "\r\n" +
                        list_aux.fname + " " + list_aux.lname + "\r\n" + "\r\n";
                }
                textBox1.Text = afisare;
                if (list.Count == 0)
                {
                    textBox1.Text = "Nu exista nicio programare";
                }
            }
            else
            {
                MessageBox.Show("Nu s-a realizat conexiunea la server", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
