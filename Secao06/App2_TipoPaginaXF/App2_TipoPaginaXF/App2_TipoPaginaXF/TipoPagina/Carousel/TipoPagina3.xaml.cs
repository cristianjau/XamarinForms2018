using App2_TipoPaginaXF.TipoPagina.Navigation;
using App2_TipoPaginaXF.TipoPagina.Tabbed;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2_TipoPaginaXF.TipoPagina.Carousel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TipoPagina3 : ContentPage
    {
        public TipoPagina3()
        {
            InitializeComponent();
        }

        private void MudarPagina(object sender, EventArgs e)
        {
            //App.Current.MainPage = new NavigationPage(new Pagina1()) { BackgroundColor = Color.Azure };
            App.Current.MainPage = new Abas();
        }
    }
}