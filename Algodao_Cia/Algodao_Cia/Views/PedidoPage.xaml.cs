using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Algodao_Cia.Views
{
	//[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PedidoPage : ContentPage
	{
		public EventHandler EventoAlterandoCampoDeQuantidade { get; set; }


        public PedidoPage()
		{
			InitializeComponent();
            

        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (EventoAlterandoCampoDeQuantidade != null)
                         EventoAlterandoCampoDeQuantidade(sender, EventArgs.Empty);
        }
    }
}