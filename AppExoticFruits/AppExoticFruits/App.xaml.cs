using AppExoticFruits.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppExoticFruits
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MarketPage();
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
