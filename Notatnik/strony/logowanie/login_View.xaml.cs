using Notatnik.operacje;
using Notatnik.strony.komunikat;
using System;
using System.Threading;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notatnik.strony.logowanie
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login_View : ContentPage
    {
        private Zmienne zmienne { get; set; }
        public login_View()
        {
            InitializeComponent();
            zmienne = new Zmienne();

            PokazGrafike();
            AnimacjaStart();

            entryLogin.Focus();
        }


        private void ZerujDane()
        {
            entryLogin.Text = string.Empty;
            entryHaslo.Text = string.Empty;
        }

        private async void Logowanie(string sLogin, string sHaslo)
        {
           
            string sWzorzecLogin = zmienne.GenerujNowyLogin(); 
            string sWzorzecHaslo = zmienne.GenerujNoweHaslo();
            //await Navigation.PushModalAsync(new glowna_View());

            if (sLogin == sWzorzecLogin && sHaslo == sWzorzecHaslo)
            {
                ZerujDane();
                await Navigation.PushModalAsync(new glowna_View());
                AnimacjaZakoncz();
            }
            else
            {
                ZerujDane();
                await Navigation.PushModalAsync(new komunikat_View(0));
            }
        }

        private void PokazGrafike()
        {
            imgLogo.Source = ImageSource.FromResource("Notatnik.grafika.ic_launcher_notepad_512.gif");
        }

        private async void AnimacjaStart()
        {
            cpLogowanie.Opacity = 0;
            await cpLogowanie.FadeTo(1, 4000);

        }

        private async void AnimacjaZakoncz()
        {
            btnLogowanie.BackgroundColor = Color.FromHex("#ba4420");
            btnLogowanie.Scale = -0.95;           
            
            cpLogowanie.Opacity = 1;
            await cpLogowanie.FadeTo(0, 4000);

        }

        private void btnLogowanie_Clicked(object sender, EventArgs e)
        {

            Logowanie(entryLogin.Text, entryHaslo.Text);
            
        }



    }
}