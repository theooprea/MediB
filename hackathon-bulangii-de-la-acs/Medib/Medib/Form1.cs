using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using System.Web;
using System.Collections.Specialized;
using System.Net;
namespace Medib
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Logare";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // daca nu sunt ambele campuri completate intoarce un mesaj de eroare
            if (UsernameBox.Text == "" || PasswordBox.Text == "")
            {
                MessageBox.Show("Inserati un username si o parola valide", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // daca sunt ambele campuri completate
            else
            {
                // se face un Post request
                HttpClient client = new HttpClient();
                LoginData login_attempt = new LoginData();
                login_attempt.Usercode = UsernameBox.Text;
                login_attempt.Password = PasswordBox.Text;
                // la adresa de login
                string url = "https://iulia.rms-it.ro/api/auth/login";
                // se formateaza sirurile pentru a putea fi folosite de server
                string content = String.Format("email={0}&password={1}",
                    Uri.EscapeDataString(login_attempt.Usercode),
                    Uri.EscapeDataString(login_attempt.Password));
                // se cripteaza
                HttpContent cont = new StringContent(content, Encoding.UTF8, "application/x-www-form-urlencoded");
                // se adauga un header
                cont.Headers.Add("x-requested-with", "XMLHttpRequest");
                HttpResponseMessage response = null;
                // se apeleaza propriu zis serverul
                response = await client.PostAsync(url, cont);
                // daca logarea a fost de succes
                if (response.IsSuccessStatusCode)
                {
                    // se decodifica raspunsul pt a face rost de token
                    string encoded = await response.Content.ReadAsStringAsync();
                    Root decoded = JsonConvert.DeserializeObject<Root>(encoded);
                    // se deschide formul 2 aka meniul doctorului
                    this.Hide();
                    Form2 new_form2 = new Form2(UsernameBox.Text, decoded.access_token);
                    new_form2.ShowDialog();
                    this.Close();
                }
                else
                {
                    // daca nu s-a putut efectua logarea se golesc campurile si apare un mesaj de eroare
                    UsernameBox.Text = "";
                    PasswordBox.Text = "";
                    MessageBox.Show("Usernameul si parola introduse nu sunt corecte!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}