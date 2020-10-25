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
    public partial class Programari : ContentPage
    {
        ObservableCollection<Programare> lista_programari = new ObservableCollection<Programare>();
        public Programari(string jsonProgramari, string accessToken)
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);

            lista_programari = JsonConvert.DeserializeObject<ObservableCollection<Programare>>(jsonProgramari);


            listaProgramari.ItemsSource = lista_programari;
        }

        private async void LogOut(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}

public class Programare
{
    public int id { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public string appointment { get; set; }
    public string doc_id { get; set; }
    public string client_id { get; set; }
    public string specializare { get; set; }
    public string fname { get; set; }
    public string lname { get; set; }

}