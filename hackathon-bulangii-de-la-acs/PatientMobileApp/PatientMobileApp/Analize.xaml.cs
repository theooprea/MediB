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
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;

namespace PatientMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Analize : ContentPage
    {
        public ObservableCollection<Analiza> lista = new ObservableCollection<Analiza>();
        public ObservableCollection<PDFs> lista_pdf = new ObservableCollection<PDFs>();
        public Analize(string token, DatePersonale datePacient, string jsonAnalize)
        {
            InitializeComponent();


            lista_pdf = JsonConvert.DeserializeObject<ObservableCollection<PDFs>>(jsonAnalize);

            foreach (PDFs pdf in lista_pdf)
            {
                if (pdf.title.Contains("Analize"))
                {
                    lista.Add(new Analiza { nume_analiza = pdf.title, link_analiza = "https://iulia.rms-it.ro" + pdf.path });
                }
            }
            ListaAnalize.ItemsSource = lista;
        }

        public async void DownloadAnaliza(object sender, ItemTappedEventArgs e)
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
}
public class Analiza
{
    public string nume_analiza { get; set; }
    public string link_analiza { get; set; }
}
public class PDFs
{
    public int id { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public string path { get; set; }
    public string title { get; set; }

}