using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MauroAvila_examen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //habilito la navegacion
            MainPage = new NavigationPage (new Login());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
