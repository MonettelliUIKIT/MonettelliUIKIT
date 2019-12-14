using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using $safeprojectname$.Views;

namespace $safeprojectname$
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
