using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using XF_Monettelli.Themes;

namespace XF_Monettelli.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfileSportPage : ContentPage
    {
        public ProfileSportPage()
        {
            InitializeComponent();
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value == true)
            {
                Application.Current.Resources.Clear();
                Application.Current.Resources = new InstagramElegantTheme();
            }
            else
            {
                Application.Current.Resources.Clear();
                Application.Current.Resources = new InstagramDarkTheme();
            }
        }
    }
}