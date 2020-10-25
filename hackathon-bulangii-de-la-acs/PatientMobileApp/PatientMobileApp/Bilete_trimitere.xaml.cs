using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PatientMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bilete_trimitere : ContentPage
    {
        public ObservableCollection<Bilet_trimitere> lista = new ObservableCollection<Bilet_trimitere>();
        public ObservableCollection<PDFs> lista_pdf = new ObservableCollection<PDFs>();
        public Bilete_trimitere(string token, string jsonBilet)
        {
            InitializeComponent();

            lista_pdf = JsonConvert.DeserializeObject<ObservableCollection<PDFs>>(jsonBilet);

            foreach (PDFs pdf in lista_pdf)
            {
                if (pdf.title.Contains("BiletTrimitere"))
                {
                    lista.Add(new Bilet_trimitere { nume_bilet = pdf.title, link_bilet = "https://iulia.rms-it.ro" + pdf.path });
                }
            }
            ListaBilete.ItemsSource = lista;
        }

        public async void DownloadBilete(object sender, ItemTappedEventArgs e)
        {
            Bilet_trimitere item = e.Item as Bilet_trimitere;
            int idx = lista.IndexOf(item);
            Uri pdf_url = new Uri(lista[idx].link_bilet);

            await Launcher.TryOpenAsync(pdf_url);
        }

        private async void LogOut(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        public class Bilet_trimitere
        {
            public string nume_bilet { get; set; }
            public string link_bilet { get; set; }
        }
    }
}