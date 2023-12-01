using Algodao_Cia.Services;
using Algodao_Cia.Views;
using Xamarin.Forms;

namespace Algodao_Cia
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AboutPage();
        }


    }
}
