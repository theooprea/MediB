using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography.X509Certificates;

namespace PatientMobileApp
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        /*
         * instantam un obiect de tip login data, in care retinem 
         * parola si codul utilizatorului
         */
        LoginData new_attempt = new LoginData();
        // configuram un client http
        HttpClient client = new HttpClient();

        // citim codul introdus din campul corespunzator
        private void WhenCodeChanged(object sender, TextChangedEventArgs e)
        {
            new_attempt.Usercode = e.NewTextValue;
        }

        // citim parola introdusa
        private void WhenPasswordChanged(object sender, TextChangedEventArgs e)
        {
            new_attempt.Password = e.NewTextValue;
        }

        // derulam procesul de logare la apasarea butonului
        private async void WhenButtonClicked(object sender, EventArgs e)
        {
           HttpResponseMessage response = null;
           string url = "https://iulia.rms-it.ro/api/auth/login";
            // traducem in format x-www-form-urlencoded parola si codul utilizatorului
           string content = String.Format("email={0}&password={1}", Uri.EscapeDataString(new_attempt.Usercode), Uri.EscapeDataString(new_attempt.Password));

           HttpContent cont = new StringContent(content, Encoding.UTF8, "application/x-www-form-urlencoded");
           cont.Headers.Add("x-requested-with", "XMLHttpRequest");

            /*
             * preluam token-ul si datele personale si mergem la pagina cu datele utilizatorului
             */
            response = await client.PostAsync(url, cont);
            if (response.IsSuccessStatusCode)
           {
                  string myJsonResponse = await response.Content.ReadAsStringAsync();
                  Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

                  client.DefaultRequestHeaders.Add("Authorization", "Bearer " + myDeserializedClass.access_token);

                  string persInfoUrl = "https://iulia.rms-it.ro/api/auth/getInfos";
                  string persInfoJson = await client.GetStringAsync(persInfoUrl);
                  DatePersonale datePacient = JsonConvert.DeserializeObject<DatePersonale>(persInfoJson);

                  await Navigation.PushAsync(new Dashboard(myDeserializedClass.access_token, datePacient));
            }
           else
           {
               ((Button)sender).Text = "Nu";
           }
        }
    }
    public class Root
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public string expires_at { get; set; }

    }
}
