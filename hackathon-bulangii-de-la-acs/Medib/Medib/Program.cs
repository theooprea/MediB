using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace Medib
{
    public class LoginData
    {
        [JsonProperty("Usercode")]
        public string Usercode { get; set; }
        [JsonProperty("Password")]
        public string Password { get; set; }

    }
    public class SearchPacient
    {
        [JsonProperty("CNP")]
        public string CNP { get; set; }
    }

    public class AddAppointment
    {
        [JsonProperty("Specializare")]
        public string Specializare { get; set; }
        [JsonProperty("CNP")]
        public string CNP { get; set; }
        [JsonProperty("DateTime")]
        public string DateTime { get; set; }
    }
    public class Root
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public string expires_at { get; set; }

    }
    public class Consult
    {
        public string infos { get; set; }
        public string doc_name { get; set; }
        public string when { get; set; }

    }
    public class Pacient
    {
        public string fname { get; set; }
        public string lname { get; set; }
        public string sex { get; set; }
        public string judet { get; set; }
        public string oras { get; set; }
        public string adresa { get; set; }
        public string cod_asigurat { get; set; }
        public string numar_document { get; set; }
        public string cnp { get; set; }
        public string data_nasterii { get; set; }

    }
    public class PDFs
    {
        public string path { get; set; }
        public string title { get; set; }
    }
    public class NewPacient
    {
        [JsonProperty("Nume")]
        public string Nume { get; set; }
        [JsonProperty("Email")]
        public string Email { get; set; }
        [JsonProperty("Prenume")]
        public string Prenume { get; set; }
        [JsonProperty("Password")]
        public string Password { get; set; }
        [JsonProperty("Data_nasterii")]
        public string Data_nasterii { get; set; }
        [JsonProperty("Sex")]
        public string Sex { get; set; }
        [JsonProperty("Judet")]
        public string Judet { get; set; }
        [JsonProperty("Oras")]
        public string Oras { get; set; }
        [JsonProperty("Adresa")]
        public string Adresa { get; set; }
        [JsonProperty("Cod_asigurat")]
        public string Cod_asigurat { get; set; }
        [JsonProperty("Numar_document")]
        public string Numar_document { get; set; }
        [JsonProperty("CNP")]
        public string CNP { get; set; }

    }

    public class Appointment
    {
        public string appointment;
        public string specializare;
        public string cnp;
        public string fname;
        public string lname;
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}