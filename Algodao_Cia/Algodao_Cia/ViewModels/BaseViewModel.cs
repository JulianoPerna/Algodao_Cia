using Algodao_Cia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Algodao_Cia.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {


    
       public Page page { get; protected set; }

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        string title = string.Empty;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        protected void ExibirPage()
        {
            App.Current.MainPage = page;
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        protected async void MensagemSucesso(string texto)
        {
           await App.Current.MainPage.DisplayAlert("Sucesso",texto,"Ok");
        }

        protected string CaixaSelecao(params string[] listaSelecao)
        {
           return App.Current.MainPage.DisplayActionSheet("Selecione","Cancelar","teste", listaSelecao).Result;
        }

        #endregion
    }
}
