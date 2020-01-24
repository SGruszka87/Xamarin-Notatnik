using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notatnik.strony.komunikat
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class komunikat_View : ContentPage
    {
        public komunikat_View()
        {
            InitializeComponent();
        }
        public komunikat_View(int typ)
        {
            InitializeComponent();


            Komunikat(typ);
        }

        private void Komunikat(int typ)
        {
            if (typ == 0)
            {
                imgKomunikat.Source = ImageSource.FromResource("Notatnik.grafika.ic_warning_amber_A700_48dp.png");
                lblKomunikat.Text = "Błędny login lub hasło";


            }
            if (typ == 1)
            {
                imgKomunikat.Source = ImageSource.FromResource("Notatnik.grafika.ic_warning_amber_A700_48dp.png");
                lblKomunikat.Text = "Błędny login lub hasło";


            }


        }

        private void btnWstecz_Clicked(object sender, EventArgs e)
        {
            AnimacjaZakoncz();
            Navigation.PopModalAsync();
        }

        private async Task AnimacjaZakoncz()
        {
            btnWstecz.BackgroundColor = Color.FromHex("#ba4420");

            btnWstecz.Scale = -0.95;
            cpKomunikat.Opacity = 1;
            await cpKomunikat.FadeTo(0, 4000);
            
        }
    }
}