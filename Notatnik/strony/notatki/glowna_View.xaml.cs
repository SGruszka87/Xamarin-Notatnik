using Notatnik.model;
using Notatnik.viewmodel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notatnik.strony
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class glowna_View : ContentPage
    {
        

        private NotatkaViewModel viewModel { get; set; }
        public glowna_View()
        {
            InitializeComponent();
            viewModel = new NotatkaViewModel();
            
        }
        public glowna_View(ObservableCollection<NotatkaViewModel> lista_Notatki)
        {
            InitializeComponent();

            viewModel = new NotatkaViewModel();
        }

        protected override void OnAppearing()
        {          

            UruchomListe();
        }

              

        private void UruchomListe()
        {

          
            lv_notatnik.ItemsSource = viewModel.Notatkas;
            lv_notatnik.ItemTapped += Lv_notatnik_ItemTapped;
        }

        private void Lv_notatnik_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var selectedItem = e.Item as NotatkaModel;
            string sTytul = selectedItem.Tytul;
            string sOpis = selectedItem.Opis;

            DisplayAlert("Tytuł: " + sTytul, "Opis: " + sOpis, "OK");
        }

        private void btnDodaj_Clicked(object sender, EventArgs e)
        {                      

            var tytul = entryTytul.Text;
            var opis = entryNotatka.Text;


            if (tytul != null && opis != null)
            {
                viewModel.DodajPozycje(tytul, opis);
                WyczyscPolaEntry();
            }
           
        }

        private void btnDodaj_Pressed(object sender, EventArgs e)
        {
            btnDodaj.BackgroundColor = Color.FromHex("#67ad32");
            btnDodaj.Text = "";

            btnDodaj.Scale = -0.8;
            btnDodaj.Opacity = 1;
            btnDodaj.FadeTo(0,2000);
        }

        private void btnDodaj_Released(object sender, EventArgs e)
        {
            btnDodaj.BackgroundColor = Color.FromHex("#e8c887");
            btnDodaj.Text = "+";
            btnDodaj.Scale = 0;
            btnDodaj.Opacity = 0;
            btnDodaj.FadeTo(0.6, 2000);

        }
        private void WyczyscPolaEntry()
        {
            entryTytul.Text = string.Empty;
            entryNotatka.Text = string.Empty;
        }

    }
}