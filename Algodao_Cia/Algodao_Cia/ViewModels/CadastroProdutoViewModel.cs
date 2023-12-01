using Algodao_Cia;
using System.Windows.Input;
using Algodao_Cia.Views;
using Xamarin.Forms;

namespace Algodao_Cia.ViewModels
{
    public class CadastroProdutoViewModel: BaseViewModel
    {


        #region Propriedades Tela
        public string DescricaoProduto { get; set; }
        public ICommand EventoSalvar { get; set; }
        public ICommand EventoVoltar { get; set; } 
        #endregion

        private string descricaoProduto { get { return DescricaoProduto; } set { DescricaoProduto = value; OnPropertyChanged("DescricaoProduto");}}


        public CadastroProdutoViewModel() 
        {
            page = new CadatroProdutoPage();
            DelegarEventos();
            page.BindingContext = this;
            App.Current.MainPage = page;
        }
        private void Salvar()
        {
            base.MensagemSucesso("Cadastro de Produto realizado Com Sucesso!!");

        }
        private void DelegarEventos()
        {
            EventoSalvar = new Command(() => { Salvar(); });
            EventoVoltar = new Command(() => { Voltar();});
        }
        private void Voltar()
        {
           Application.Current.MainPage = new AboutPage();
        }
    }
}
