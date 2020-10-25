using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace PatientMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatePersonalePage : ContentPage
    {
        ObservableCollection<CampDate> listaDatePacient = new ObservableCollection<CampDate>();

        public DatePersonalePage(DatePersonale datePacient)
        {
            InitializeComponent();

            listaDatePacient.Add(new CampDate { campDate = "Nume:   " + datePacient.lname + " " + datePacient.fname });
            if (datePacient.sex.Equals("1"))
                listaDatePacient.Add(new CampDate { campDate = "Sex: M" });
            else
                listaDatePacient.Add(new CampDate { campDate = "Sex: F" });
            listaDatePacient.Add(new CampDate { campDate = "Judet: " + datePacient.judet });
            listaDatePacient.Add(new CampDate { campDate = "Oras: " + datePacient.oras });
            listaDatePacient.Add(new CampDate { campDate = "Adresa: " + datePacient.adresa });
            listaDatePacient.Add(new CampDate { campDate = "Nr. document: " + datePacient.numar_document });
            listaDatePacient.Add(new CampDate { campDate = "Cod asigurat: " + datePacient.cod_asigurat });
            listaDatePacient.Add(new CampDate { campDate = "CNP: " + datePacient.cnp });
            listaDatePacient.Add(new CampDate { campDate = "Data nasterii: " + datePacient.data_nasterii });

            ListaDate.ItemsSource = listaDatePacient;
        }

        private async void LogOut(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }

    public class CampDate
    {
        public string campDate { get; set; }
    }
    public class DatePersonale
    {
        public int id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string user_id { get; set; }
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
}