using System.Windows.Input;
using Xamarin.Forms;

namespace Algodao_Cia.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {


        public ICommand CadastrarProduto { get; set; }
        public ICommand CadastrarCliente { get; set; }
        public ICommand NovoPedido { get; set; }
        public ICommand Imprimir { get; set; }

        public ImageSource Imagem { get; set; }
        public ImageSource ImagemBotao { get; set; }


        public AboutViewModel()
        {
            Title = "BEM VIMDO";
            DelegarEventos();
            
            OnPropertyChanged("ImagemBotao");
        }

        private void DelegarEventos()
        {
            this.CadastrarCliente = new Command(() => { this.EventoChamarCadastroCliente(); });
            this.CadastrarProduto = new Command(() => { this.EventoChamarCadastroProduto(); });
            this.NovoPedido = new Command(() => { EventoNovoPedido(); });
        }

        private void EventoNovoPedido()
        {
            new PedidoViewModel();
        }
        private void EventoChamarCadastroCliente()
        {
            new CadastroClienteViewModel(this);
        }
        private void EventoChamarCadastroProduto()
        {
            new CadastroProdutoViewModel();
        }
    }
}