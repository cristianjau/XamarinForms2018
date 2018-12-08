using App2_TipoPaginaXF.TipoPagina.Navigation;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2_TipoPaginaXF.TipoPagina.Tabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Abas : TabbedPage
    {
        public Abas()
        {
            InitializeComponent();

            Children.Add(new NavigationPage(new Pagina1()) { Title = "Titulo 3" });
        }
    }
}