using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFMonettelli.Views.ShellTemplates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutHeaderTemplate : Grid
    {
        public FlyoutHeaderTemplate()
        {
            InitializeComponent();
        }
    }
}