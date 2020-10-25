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
    public partial class Form3 : Form
    {
        // pentru a retine numele de utilizator al doctorului cat si tokenul acestuia
        static string user;
        public string current_token;
        public Form3(string username, string token)
        {
            InitializeComponent();
            Form3.user = username;
            Text = "Add patient";
            current_token = token;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        // butonul de a ne intoarce la meniul doctorului
        private void Back_Click_1(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Modificarile neinregistrate vor fi pierdute!", "Confirm Action", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (confirmResult == DialogResult.OK)
            {
                this.Hide();
                var new_form2 = new Form2(user, current_token);
                new_form2.ShowDialog();
                this.Close();
            }
            else
            {
                
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // daca este vreo casuta lasata libera se da mesaj de eroare
            if((NumeBox.Text.Equals("") || PrenumeBox.Text.Equals("") || Data_nasteriiBox.Text.Equals("")
                || SexBox.Text.Equals("") || JudetBox.Text.Equals("") || OrasBox.Text.Equals("") ||
                AdresaBox.Text.Equals("") || Cod_asiguratBox.Text.Equals("") || NumarDocumentBox.Text.Equals("") ||
                CNPBox.Text.Equals("") || EmailBox.Text.Equals("") || ParolaBox.Text.Equals("") || UsernameBox.Text.Equals("")))
            {
                var confirmResult = MessageBox.Show("Nu au fost completate toate campurile!", "Eroare!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            // daca nu, se face un request la server pt a inregistra pacientul
            else
            {
                HttpClient client = new HttpClient();
                NewPacient pacient = new NewPacient();
                string url = "https://iulia.rms-it.ro/api/auth/client";
                string content = String.Format("fName={0}&lName={1}&email={2}&spassword={3}&name={4}&sex={5}&judet={6}" +
                    "&oras={7}&adresa={8}&cod_asigurat={9}&numar_document={10}&cnp={11}&data_nasterii={12}",
                    Uri.EscapeDataString(NumeBox.Text),
                    Uri.EscapeDataString(PrenumeBox.Text),
                    Uri.EscapeDataString(EmailBox.Text),
                    Uri.EscapeDataString(ParolaBox.Text),
                    Uri.EscapeDataString(UsernameBox.Text),
                    Uri.EscapeDataString(SexBox.Text),
                    Uri.EscapeDataString(JudetBox.Text),
                    Uri.EscapeDataString(OrasBox.Text),
                    Uri.EscapeDataString(AdresaBox.Text),
                    Uri.EscapeDataString(Cod_asiguratBox.Text),
                    Uri.EscapeDataString(NumarDocumentBox.Text),
                    Uri.EscapeDataString(CNPBox.Text), 
                    Uri.EscapeDataString(Data_nasteriiBox.Text));
                HttpContent cont = new StringContent(content, Encoding.UTF8, "application/x-www-form-urlencoded");
                // se adauga headerele corespunzatoare
                cont.Headers.Add("x-requested-with", "XMLHttpRequest");
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + current_token);
                HttpResponseMessage response = null;
                response = await client.PostAsync(url, cont);
                // daca operatiunea s-a efectuat cu succes ne intoarcem automat la meniul doctorului
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Utilizatorul a fost creat cu succes!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    var new_form2 = new Form2(user, current_token);
                    new_form2.ShowDialog();
                    this.Close();
                }
                else
                {

                }
            }
        }
    }
}
