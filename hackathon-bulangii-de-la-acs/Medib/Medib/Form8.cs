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
    public partial class Form8 : Form
    {
        public string current_token, current_cnp;
        public Form8(string token, string cnp)
        {
            InitializeComponent();
            current_token = token;
            current_cnp = cnp;
        }
        // se creaza un nou consult care e trimis in baza de date cu un request de tip post
        private async void AddButton_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            Consult consult = new Consult();
            consult.infos = infosBox.Text;
            consult.doc_name = doc_nameBox.Text;
            consult.when = whenBox.Text;
            // la adresa personala a pacientului de consulturi
            string url = "https://iulia.rms-it.ro/api/auth/getCons/" + current_cnp;
            // in formatul dat
            string content = String.Format("infos={0}&doc_name={1}&when={2}",
                Uri.EscapeDataString(consult.infos),
                Uri.EscapeDataString(consult.doc_name),
                Uri.EscapeDataString(consult.when));
            HttpContent cont = new StringContent(content, Encoding.UTF8, "application/x-www-form-urlencoded");
            // cu headerele date
            cont.Headers.Add("x-requested-with", "XMLHttpRequest");
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + current_token);
            HttpResponseMessage response = null;
            // se face requestul de tip post
            response = await client.PostAsync(url, cont);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Consultul a fost inregistrat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Consultul nu a putut fi inregistrat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // se inchide formul automat la crearea consultului
            this.Close();
        }
    }
}
