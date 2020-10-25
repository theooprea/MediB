using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System.Security.Principal;
using Newtonsoft.Json;

namespace PatientMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Retete : ContentPage
    {
        public ObservableCollection<Reteta> lista_retete = new ObservableCollection<Reteta>();
        public ObservableCollection<PDFs> lista_pdf = new ObservableCollection<PDFs>();

        public Retete(string token, string jsonRetete)
        {
            InitializeComponent();

            lista_pdf = JsonConvert.DeserializeObject<ObservableCollection<PDFs>>(jsonRetete);

            foreach (PDFs pdf in lista_pdf)
            {
                if (pdf.title.Contains("Reteta"))
                {
                    lista_retete.Add(new Reteta { nume_reteta = pdf.title, link_reteta = "https://iulia.rms-it.ro" + pdf.path });
                }
            }
            ListaRetete.ItemsSource = lista_retete;
        }

        public async void DownloadReteta(object sender, ItemTappedEventArgs e)
        {
            Reteta item = e.Item as Reteta;
            int idx = lista_retete.IndexOf(item);
            Uri pdf_url = new Uri(lista_retete[idx].link_reteta);

            await Launcher.TryOpenAsync(pdf_url);
        }

        private async void LogOut(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
public class Reteta
{
    public string nume_reteta { get; set; }
    public string link_reteta { get; set; }
}