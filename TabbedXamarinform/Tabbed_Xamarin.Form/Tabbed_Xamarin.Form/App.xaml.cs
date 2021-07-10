using System;
using Tabbed_Xamarin.Form.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tabbed_Xamarin.Form
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AnimalTabbedPage());
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
