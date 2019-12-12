using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using XFMonettelli.Views;

namespace XFMonettelli
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            //MainPage = new DemoPage();
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
