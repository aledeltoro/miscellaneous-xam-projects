using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AndroidSpecificFeatures.Views;

namespace AndroidSpecificFeatures
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ContainerTabbedPage();
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
