using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
namespace Medib
{
    public partial class Form10 : Form
    {
        public string current_token, data_type, filePath, pacient_curent;
        public Stream fileStream;
        public byte[] fileBytes;
        // butonul care adauga fisierul in baza de date, acesta trebuie sa contina unul din stringurile cerute pentru a putea fi
        // procesat mai departe, daca nu contine se va primi un mesaj de eroare
        private async void AddButton_Click(object sender, EventArgs e)
        {
            if (FisierBox.Text == "" || NameBox.Text == "")
            {
                MessageBox.Show("Completati ambele campuri", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(NameBox.Text.Contains("Reteta") || NameBox.Text.Contains("BiletTrimitere") || NameBox.Text.Contains("Imagistica") ||
                NameBox.Text.Contains("Analize"))
            {
                // se initializeaza clientul, multidata care contine fisierul si titlul acestuia si se pun headerele
                HttpClient client = new HttpClient();
                string url = "https://iulia.rms-it.ro/api/auth/getPDF/" + pacient_curent;
                var form = new MultipartFormDataContent();
                var fs = File.OpenRead(filePath);
                var streamContent = new StreamContent(fs);
                var fileContent = new ByteArrayContent(await streamContent.ReadAsByteArrayAsync());
                fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
                form.Add(fileContent, "pdf", Path.GetFileName(filePath));
                form.Add(new StringContent(NameBox.Text), "title");
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + current_token);
                HttpResponseMessage response = await client.PostAsync(url, form);
                Console.WriteLine(response.Content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Pdf-ul a fost incarcat cu succes!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nu s-a putut incarca pdf-ul", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Numele fisierului trebuie sa aiba unul din urmatoarele expresii pentru a fi diferentiate: Retete / " +
                    "BiletTrimitere / Imagistica / Analize", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // se cauta fisierul care se doreste incarcat
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "pdf files (*.pdf)|*.pdf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;
                FisierBox.Text = filePath;

                //Read the contents of the file into a stream
                fileStream = openFileDialog.OpenFile();
                fileBytes = File.ReadAllBytes(filePath);
            }
        }

        public Form10(string token, string pacient, string data)
        {
            InitializeComponent();
            label3.Text = "Adaugati fisier pentru pacientul " + pacient;
            current_token = token;
            data_type = data;
            pacient_curent = pacient;
        }
    }
}
