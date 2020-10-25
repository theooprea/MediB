using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PatientMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dashboard : MasterDetailPage
    {
        public class MenuItems
        {
            public string OptionName { get; set; }
        }
        List<MenuItems> menu;
        string accessToken;
        DatePersonale datePacient;

        public Dashboard(string token, DatePersonale datepacient)
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);

            accessToken = token;
            datePacient = datepacient; 

            menu = new List<MenuItems>();

            menu.Add(new MenuItems { OptionName = "Retete" });
            menu.Add(new MenuItems { OptionName = "Analize" });
            menu.Add(new MenuItems { OptionName = "Imagistica" });
            menu.Add(new MenuItems { OptionName = "Bilete de trimitere" });
            menu.Add(new MenuItems { OptionName = "Consulturi" });
            menu.Add(new MenuItems { OptionName = "Programari" });
            menu.Add(new MenuItems { OptionName = "Date Personale" });
            
            menuList.ItemsSource = menu;

            Detail = new NavigationPage(new DatePersonalePage(datePacient));
        }

        private async void Item_Tapped(object sender, ItemTappedEventArgs e)
        {
            MenuItems selected_item = e.Item as MenuItems;

            HttpClient client = new HttpClient();

            switch (selected_item.OptionName)
            {
                case "Retete":
                    {
                        client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);
                        string url_pdfs = "https://iulia.rms-it.ro/api/auth/getPDF/" + datePacient.cnp;
                        string jsonRetete = await client.GetStringAsync(url_pdfs);

                        Detail = new NavigationPage(new Retete(accessToken, jsonRetete));
                        IsPresented = false;
                        break;
                    }
                case "Analize":
                    {
                        client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);
                        string url_pdfs = "https://iulia.rms-it.ro/api/auth/getPDF/" + datePacient.cnp;
                        string jsonAnalize = await client.GetStringAsync(url_pdfs);
             
                        Detail = new NavigationPage(new Analize(accessToken, datePacient, jsonAnalize));
                        IsPresented = false;
                        break;
                    }
                case "Consulturi":
                    {
                        client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);
                        string url_consulturi = "https://iulia.rms-it.ro/api/auth/getCons/" + datePacient.cnp;
                        string jsonConsulturi = await client.GetStringAsync(url_consulturi);

                        Detail = new NavigationPage(new Consulturi(accessToken, jsonConsulturi));
                        IsPresented = false;
                        break;
                    }
                case "Date Personale":
                    {
                        Detail = new NavigationPage(new DatePersonalePage(datePacient));
                        IsPresented = false;
                        break;
                    }
                case "Programari":
                    {
                        client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);
                        string urlProgramari = "https://iulia.rms-it.ro/api/auth/getApp";
                        string jsonProgramari = await client.GetStringAsync(urlProgramari);

                        Detail = new NavigationPage(new Programari(jsonProgramari, accessToken));
                        IsPresented = false;
                        break;
                    }
                case "Imagistica":
                    {
                        client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);
                        string url_imag = "https://iulia.rms-it.ro/api/auth/getPDF/" + datePacient.cnp;
                        string jsonImag = await client.GetStringAsync(url_imag);

                        Detail = new NavigationPage(new Imagistica(accessToken, jsonImag));
                        IsPresented = false;
                        break;
                    }
                case "Bilete de trimitere":
                    {
                        client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);
                        string url_bilet = "https://iulia.rms-it.ro/api/auth/getPDF/" + datePacient.cnp;
                        string jsonBilet = await client.GetStringAsync(url_bilet);

                        Detail = new NavigationPage(new Bilete_trimitere(accessToken, jsonBilet));
                        IsPresented = false;
                        break;
                    }
            }
        }
    }

    public class MenuItems
    {
        public string OptionName { get; set; }
    }
}
