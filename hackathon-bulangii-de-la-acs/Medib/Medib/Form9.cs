using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;

namespace Medib
{
    public partial class Form9 : Form
    {
        // am creat o lista pentru a pastra toate pdfurile unui pacient urmand ca apoi sa le selectez pe cele care contin stringul cerut,
        // fie Reteta, fie BiletTrimitere fie Imagistica fie Analize
        public string current_token, date_type, pacient_curent;
        List<PDFs> list_chosen = new List<PDFs>();
        public Form9(string token, List<PDFs> list, string date, string pacient)
        {
            InitializeComponent();
            date_type = date;
            pacient_curent = pacient;
            // in functie de ce date sunt cerute creez lista (implementarea e deja scrisa in c#)
            if (date.Equals("Retete"))
            {
                label1.Text = "Pacientul " + pacient + " are urmatoarele retete valabile:";
                foreach (PDFs i in list)
                {
                    if (i.title.Contains("Reteta"))
                    {
                        list_chosen.Add(i);
                    }
                }
            }
            else if (date.Equals("Bilete de trimitere"))
            {
                label1.Text = "Pacientul " + pacient + " are urmatoarele bilete de trimitere valabile:";
                foreach (PDFs i in list)
                {
                    if (i.title.Contains("BiletTrimitere"))
                    {
                        list_chosen.Add(i);
                    }
                }
            }
            else if (date.Equals("Imagistica"))
            {
                label1.Text = "Pacientul " + pacient + " are urmatoarele investigatii radiologice valabile:";
                foreach (PDFs i in list)
                {
                    if (i.title.Contains("Imagistica"))
                    {
                        list_chosen.Add(i);
                    }
                }
            }
            else
            {
                label1.Text = "Pacientul " + pacient + " are urmatoarele analize valabile:";
                foreach (PDFs i in list)
                {
                    if (i.title.Contains("Analize"))
                    {
                        list_chosen.Add(i);
                    }
                }
            }
            // dupa ce am creat lista afisez numele celor gasite in ListView
            foreach (PDFs i in list_chosen)
            {
                listView1.Items.Add(new ListViewItem(i.title));
            }
        }
        // daca e un nume selectat, formez linkul de la care descarc pdful cu linkul de baza al serverului si cel asociat elementului
        // selectat conform cu structura de date
        private void DownloadButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int index = listView1.FocusedItem.Index;
                string link = "https://iulia.rms-it.ro" + list_chosen[index].path;
                // se creaza o fereastra de salvare a fisierului
                var dialog = new SaveFileDialog();
                dialog.Filter = "Document (.pdf)|.pdf";

                dialog.FileName = date_type + "_" + pacient_curent;
                dialog.InitialDirectory = "C:\\";
                // se porneste fereastra
                var result = dialog.ShowDialog(); //shows save file dialog
                // daca a fost descarcat fisierul afisez un mesaj de succes, iar daca nu, nu se intampla nimic(de ex doctorul iese din
                // fereastra de descarcare)
                if (result == DialogResult.OK)
                {
                    Console.WriteLine("writing to: " + dialog.FileName); //prints the file to save

                    var wClient = new WebClient();
                    wClient.DownloadFile(link, dialog.FileName);
                    MessageBox.Show("Fisierul a fost descarcat!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
