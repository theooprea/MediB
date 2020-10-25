
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
    public partial class Form2 : Form
    {
        public string current_token;
        public Form2(string username, string token)
        {
            InitializeComponent();
            LoggedInAsLabel.Text = username;
            // tin cont de tokenul de la logare pt a-l folosi la alte actiuni
            current_token = token;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // caseta pt a confirma daca medicul doreste sau nu delogarea
            var confirmResult = MessageBox.Show("Sunteti siguri ca doriti delogarea?", "Confirm Action",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            // daca da, trimit un Get Request la adresa de delogare
            if (confirmResult == DialogResult.OK)
            {
                HttpClient client = new HttpClient();
                string url = "https://iulia.rms-it.ro/api/auth/logout";
                // adaug un header de autentificare
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + current_token);
                HttpResponseMessage response = await client.GetAsync(url);
                // daca delogarea a avut loc cu succes dau mesajul corespunzator si deschid formul de logare
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Delogat cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form1 new_form1 = new Form1();
                    new_form1.ShowDialog();
                    this.Close();
                }
                // daca nu a mers delogarea
                else
                {
                    MessageBox.Show("Nu s-a putut efectua delogarea", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Hide();
                    Form1 new_form1 = new Form1();
                    new_form1.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                
            }
        }
        // daca se apasa butonul de creare a unui pacient deschid un form corespunzator
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 new_form3 = new Form3(LoggedInAsLabel.Text, current_token);
            new_form3.ShowDialog();
            this.Close();
        }
        // cauta in baza de date pacientul cu cnp-ul introdus
        private async void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchBox.Text.All(char.IsDigit) && SearchBox.Text != "")
            {
                HttpClient client = new HttpClient();
                SearchPacient pacient = new SearchPacient();
                pacient.CNP = SearchBox.Text;
                string url = "https://iulia.rms-it.ro/api/auth/client/" + pacient.CNP;
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + current_token);
                HttpResponseMessage response = null;
                response = await client.GetAsync(url);
                // daca e gasit, e deschisa o tabela a pacientului respectiv
                if (response.IsSuccessStatusCode)
                {
                    string encoded = await response.Content.ReadAsStringAsync();
                    Pacient decoded = JsonConvert.DeserializeObject<Pacient>(encoded);
                    this.Hide();
                    Form4 new_form4 = new Form4(SearchBox.Text, LoggedInAsLabel.Text, current_token, decoded);
                    new_form4.ShowDialog();
                    this.Close();
                }
                // mesajele de eroare in cazul in care nu a fost gasit cnpu-ul cautat sau daca nu e un cnp valid
                else
                {
                    MessageBox.Show("CNP-ul inserat nu exista in baza de date", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Inserati un CNP valid", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // se deschide pagina de programari
        private void ProgramariButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 new_form5 = new Form5(LoggedInAsLabel.Text, current_token);
            new_form5.ShowDialog();
            this.Close();
        }
    }
}
