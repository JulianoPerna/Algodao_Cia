using Algodao_Cia;
using System;
using System.Windows.Input;
using Algodao_Cia.Views;
using Xamarin.Forms;

namespace Algodao_Cia.ViewModels
{
    public class CadastroClienteViewModel : BaseViewModel
    {

       private readonly BaseViewModel _viewModelInicial;
        public ICommand salvarCadastro { get; set; }
        public ICommand eventoVoltar { get; set; }

        public string nomeCliente { get; set; }
        public string telefoneCliente { get; set; }
        public string rua { get; set; }
        public string numero { get; set; }

        
        private string NomeCliente
        {
            get
            { 
                return nomeCliente; 
            }
            set
            {
                nomeCliente = value;
                OnPropertyChanged("nomeCliente");
            }
        }
        private string TelefoneCliente
        {
            get
            {
                return telefoneCliente;
            }
            set
            {
                telefoneCliente = value;
                OnPropertyChanged("telefoneCliente");
            }
        }
        private string Rua
        {
            get
            {
                return rua;
            }
            set
            {
                rua = value;
                OnPropertyChanged("rua");
            }
        }
        private string Numero
        {
            get
            {
                return numero;
            }
            set
            {
                numero = value;
                OnPropertyChanged("numero");
            }
        }




        public CadastroClienteViewModel(BaseViewModel viewModelInicial)
        {
            _viewModelInicial  = viewModelInicial;
            page = new CadastroClientePage();
            DelegarEventos();
            page.BindingContext = this;
            Application.Current.MainPage = page;
        }

        private void DelegarEventos()
        {
            this.salvarCadastro = new Command(() => { this.EventoSalvarCadastro(); });
            this.eventoVoltar = new Command( () => { EventoVoltar(); }); ;
        }
        private void EventoVoltar()
        {
            App.Current.MainPage = new AboutPage();
        }


        private void EventoSalvarCadastro()
        {
            try
            {
                Rua = NomeCliente;


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
