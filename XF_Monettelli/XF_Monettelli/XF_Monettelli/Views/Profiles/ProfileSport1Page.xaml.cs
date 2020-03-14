using System;
using System.Collections.Generic;

using Xamarin.Forms;

using Xamarin.Forms.PancakeView;
using XF_Monettelli.Themes;

namespace XF_Monettelli.Views
{
    public partial class ProfileSport1Page : ContentPage
    {
        public ProfileSport1Page()
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
