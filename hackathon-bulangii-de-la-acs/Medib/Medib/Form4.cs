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
    public partial class Form4 : Form
    {
        public string doctor;
        public string current_token;
        Pacient pacient_curent;
        public Form4(string patientname, string username, string token, Pacient pacient)
        {
            InitializeComponent();
            PatientNameLabel.Text = patientname;
            doctor = username;
            current_token = token;
            pacient_curent = pacient;
        }
        // daca se apasa butonul de date personale se afiseaza in textbox datele intr-un format sugestiv
        private void PersonalDataButton_Click(object sender, EventArgs e)
        {
            string sex;
            if (pacient_curent.sex.Equals("1"))
            {
                sex = "Masculin";
            }
            else
            {
                sex = "Feminin";
            }
            DetailLabel.Text = "Date personale";
            ContentBox.Text = "Nume pacient: " + pacient_curent.fname + " " + pacient_curent.lname + System.Environment.NewLine +
                System.Environment.NewLine + "Sex: " + sex + System.Environment.NewLine + System.Environment.NewLine + "Adresa: Judet " +
                pacient_curent.judet + ", " + pacient_curent.oras + " " + pacient_curent.adresa + System.Environment.NewLine +
                System.Environment.NewLine + "Cod asigurat: " + pacient_curent.cod_asigurat + System.Environment.NewLine +
                System.Environment.NewLine + "Numar document: " + pacient_curent.numar_document + System.Environment.NewLine +
                System.Environment.NewLine + "CNP: " + pacient_curent.cnp + System.Environment.NewLine + System.Environment.NewLine +
                "Data nasterii: " + pacient_curent.data_nasterii;


        }
        // daca se apasa butonul de imagistica se afiseaza numele pdf-urilor valabile intr-un form nou
        private async void ImagingButton_Click(object sender, EventArgs e)
        {
            ContentBox.Text = "";
            DetailLabel.Text = "Imagistica";
            HttpClient client = new HttpClient();
            string url = "https://iulia.rms-it.ro/api/auth/getPDF/" + pacient_curent.cnp;
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + current_token);
            HttpResponseMessage response = null;
            response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string encoded = await response.Content.ReadAsStringAsync();
                List<PDFs> decoded = JsonConvert.DeserializeObject<List<PDFs>>(encoded);
                Form9 new_form9 = new Form9(current_token, decoded, "Imagistica", pacient_curent.cnp);
                new_form9.Show();
            }
            else
            {
                MessageBox.Show("Nu sunt Programari create, apasati Add Entry pentru a adauga una", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // daca se apasa butonul de retete se afiseaza numele pdf-urilor valabile intr-un form nou
        private async void ReteteButton_Click(object sender, EventArgs e)
        {
            ContentBox.Text = "";
            DetailLabel.Text = "Retete";
            HttpClient client = new HttpClient();
            string url = "https://iulia.rms-it.ro/api/auth/getPDF/" + pacient_curent.cnp;
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + current_token);
            HttpResponseMessage response = null;
            response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string encoded = await response.Content.ReadAsStringAsync();
                List<PDFs> decoded = JsonConvert.DeserializeObject<List<PDFs>>(encoded);
                Form9 new_form9 = new Form9(current_token, decoded, "Retete", pacient_curent.cnp);
                new_form9.Show();
            }
            else
            {
                MessageBox.Show("Nu sunt Programari create, apasati Add Entry pentru a adauga una", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // daca se apasa butonul de Istoria analizelor se afiseaza numele pdf-urilor valabile intr-un form nou
        private async void MedicalHistoryButton_Click(object sender, EventArgs e)
        {
            ContentBox.Text = "";
            DetailLabel.Text = "Istoric Analize";
            HttpClient client = new HttpClient();
            string url = "https://iulia.rms-it.ro/api/auth/getPDF/" + pacient_curent.cnp;
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + current_token);
            HttpResponseMessage response = null;
            response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string encoded = await response.Content.ReadAsStringAsync();
                List<PDFs> decoded = JsonConvert.DeserializeObject<List<PDFs>>(encoded);
                Form9 new_form9 = new Form9(current_token, decoded, "Istoric analize", pacient_curent.cnp);
                new_form9.Show();
            }
            else
            {
                MessageBox.Show("Nu sunt Programari create, apasati Add Entry pentru a adauga una", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // daca se apasa butonul de consulturi se afiseaza datele consulturilor deja existente in textbox
        private async void ConsultsButton_Click(object sender, EventArgs e)
        {
            ContentBox.Text = "";
            DetailLabel.Text = "Consulturi";
            HttpClient client = new HttpClient();
            string url = "https://iulia.rms-it.ro/api/auth/getCons/" + pacient_curent.cnp;
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + current_token);
            HttpResponseMessage response = null;
            response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string encoded = await response.Content.ReadAsStringAsync();
                List<Consult> decoded = JsonConvert.DeserializeObject<List<Consult>>(encoded);
                foreach (Consult i in decoded)
                {
                    ContentBox.Text = ContentBox.Text + "Nume doctor: " + i.doc_name + System.Environment.NewLine +
                        "Data consultului: " + i.when + System.Environment.NewLine + "Detalii consult: " +
                        i.infos + System.Environment.NewLine + System.Environment.NewLine;
                }
            }
            else
            {
                MessageBox.Show("Nu sunt Programari create, apasati Add Entry pentru a adauga una", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // daca se apasa butonul de Bilete de trimitere se afiseaza numele pdf-urilor valabile intr-un form nou
        private async void BileteDeTrimitereButton_Click(object sender, EventArgs e)
        {
            ContentBox.Text = "";
            DetailLabel.Text = "Bilete de trimitere";
            HttpClient client = new HttpClient();
            string url = "https://iulia.rms-it.ro/api/auth/getPDF/" + pacient_curent.cnp;
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + current_token);
            HttpResponseMessage response = null;
            response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string encoded = await response.Content.ReadAsStringAsync();
                List<PDFs> decoded = JsonConvert.DeserializeObject<List<PDFs>>(encoded);
                Form9 new_form9 = new Form9(current_token, decoded, "Bilete de trimitere", pacient_curent.cnp);
                new_form9.Show();
            }
            else
            {
                MessageBox.Show("Nu sunt Programari create, apasati Add Entry pentru a adauga una", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // butonul de inapoi
        private void OtherPacientButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Parasiti sesiunea pacientului curent?", "Confirm Action", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (confirmResult == DialogResult.OK)
            {
                this.Hide();
                Form2 new_form2 = new Form2(doctor, current_token);
                new_form2.ShowDialog();
                this.Close();
            }
            else
            {

            }
        }
        // butonul de adaugare date, care daca a fost accesata partea de date general acestea nu pot fi modificate, daca a fost selectata
        // partea de consulturi se va deschide un form pentru a adauga un nou consult, iar daca nu se selecteaza nimic, sau una din cele 4
        // ramase se va deschide un form pt a adauga un fisier pdf
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (DetailLabel.Text.Equals("Date personale"))
            {
                MessageBox.Show("Nu puteti modifica datele generale ale pacientului", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DetailLabel.Text.Equals("Consulturi"))
            {
                Form8 new_form8 = new Form8(current_token, pacient_curent.cnp);
                new_form8.Show();
                ContentBox.Text = "";
            }
            else if (DetailLabel.Text.Equals("Retete"))
            {
                Form10 new_form10 = new Form10(current_token, pacient_curent.cnp, "Retete");
                new_form10.Show();
                ContentBox.Text = "";
            }
            else if (DetailLabel.Text.Equals("Bilete de trimitere"))
            {
                Form10 new_form10 = new Form10(current_token, pacient_curent.cnp, "Bilete de trimitere");
                new_form10.Show();
                ContentBox.Text = "";
            }
            else if (DetailLabel.Text.Equals("Imagistica"))
            {
                Form10 new_form10 = new Form10(current_token, pacient_curent.cnp, "Imagistica");
                new_form10.Show();
                ContentBox.Text = "";
            }
            else
            {
                Form10 new_form10 = new Form10(current_token, pacient_curent.cnp, "Istoric analize");
                new_form10.Show();
                ContentBox.Text = "";
            }
        }
    }
}
