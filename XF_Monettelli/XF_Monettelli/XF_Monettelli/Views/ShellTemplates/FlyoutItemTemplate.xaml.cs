using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_Monettelli.Views.ShellTemplates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutItemTemplate : Grid
    {
        public FlyoutItemTemplate()
        {
            InitializeComponent();
        }
    }
}