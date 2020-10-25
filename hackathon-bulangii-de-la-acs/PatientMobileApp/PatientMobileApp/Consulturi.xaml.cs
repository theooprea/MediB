using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PatientMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Consulturi : ContentPage
    {
        public ObservableCollection<Consult> lista_consult = new ObservableCollection<Consult>();
        public Consulturi(string token, string jsonConsulturi)
        {
            InitializeComponent();

            lista_consult = JsonConvert.DeserializeObject<ObservableCollection<Consult>>(jsonConsulturi);
            listView.ItemsSource = lista_consult;
        }

        private async void LogOut(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }

    public class Consult
    {
        public int id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string client_id { get; set; }
        public string infos { get; set; }
        public string doc_name { get; set; }
        public string when { get; set; }

    }
}