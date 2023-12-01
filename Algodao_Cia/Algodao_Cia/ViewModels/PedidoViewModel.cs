using Algodao_Cia.Views;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Algodao_Cia.ViewModels
{
    class PedidoViewModel: BaseViewModel
    {




        public ICommand EventoVoltar { get; set; }
        public EventHandler EventoAlterandoQuantidade { get; set; }
        public decimal QuantidadeInformada { get; set; }
        public PedidoViewModel()
        {
            base.page = new PedidoPage();
            DelegarEventos();
            page.BindingContext = this;
            App.Current.MainPage = page;
        }

        private void DelegarEventos()
        {
            EventoVoltar = new Command(Voltar);
            this.EventoAlterandoQuantidade += AltarandoQuantidade;
            ((PedidoPage)page).EventoAlterandoCampoDeQuantidade += AltarandoQuantidade;
        }
        private void AltarandoQuantidade(object sender, EventArgs args )
        {


        }
        public void Voltar()
        {
            App.Current.MainPage = new AboutPage();
        }
    }
}
