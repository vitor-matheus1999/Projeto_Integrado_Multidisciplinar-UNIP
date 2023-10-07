using MobileHolerite.Services;
using MobileHolerite.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileHolerite
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
