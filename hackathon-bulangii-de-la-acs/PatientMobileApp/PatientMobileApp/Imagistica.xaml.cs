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
    public partial class Imagistica : ContentPage
    {

        public ObservableCollection<Analiza> lista = new ObservableCollection<Analiza>();
        public ObservableCollection<PDFs> lista_pdf = new ObservableCollection<PDFs>();
        public Imagistica(string token, string jsonImag)
        {
            InitializeComponent();

            lista_pdf = JsonConvert.DeserializeObject<ObservableCollection<PDFs>>(jsonImag);

            foreach (PDFs pdf in lista_pdf)
            {
                if (pdf.title.Contains("Imagistica"))
                {
                    lista.Add(new Analiza { nume_analiza = pdf.title, link_analiza = "https://iulia.rms-it.ro" + pdf.path });
                }
            }
            ListaImagistica.ItemsSource = lista;
        }

        public async void DownloadImagistica(object sender, ItemTappedEventArgs e)
        {
            Analiza item = e.Item as Analiza;
            int idx = lista.IndexOf(item);
            Uri pdf_url = new Uri(lista[idx].link_analiza);

            await Launcher.TryOpenAsync(pdf_url);
        }

        private async void LogOut(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

    }

    public class Analiza
    {
        public string nume_analiza { get; set; }
        public string link_analiza { get; set; }
    }
}