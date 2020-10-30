using opsss.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace opsss
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MyMainPage();
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
