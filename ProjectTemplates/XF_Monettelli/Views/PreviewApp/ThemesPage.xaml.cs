using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using $safeprojectname$.Themes;

namespace $safeprojectname$.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThemesPage : ContentPage
    {
        public ThemesPage()
        {
            InitializeComponent();

        }

        private void Light_Tapped(object sender, EventArgs e)
        {
            Application.Current.Resources.Clear();
            Application.Current.Resources = new LightTheme();
        }

        private void Dark_Tapped(object sender, EventArgs e)
        {
            Application.Current.Resources.Clear();
            Application.Current.Resources = new DarkTheme();
        }

        private void InstagramDark_Tapped(object sender, EventArgs e)
        {
            Application.Current.Resources.Clear();
            Application.Current.Resources = new InstagramDarkTheme();
        }

        private void InstagramElegant_Tapped(object sender, EventArgs e)
        {
            Application.Current.Resources.Clear();
            Application.Current.Resources = new InstagramElegantTheme();
        }
    }
}