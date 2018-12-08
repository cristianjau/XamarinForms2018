using App2_TipoPaginaXF.TipoPagina.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2_TipoPaginaXF.TipoPagina.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterPage : MasterDetailPage
    {
		public MasterPage ()
		{
			InitializeComponent ();
		}

        private void MudarPagina1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina1());
            IsPresented = false;
        }

        private void MudarPagina2(object sender, EventArgs e)
        {
            Detail = new Pagina2();
            IsPresented = false;
        }

        private void MudarPagina3(object sender, EventArgs e)
        {
            Detail = new Conteudo();
            IsPresented = false;
        }
    }
}