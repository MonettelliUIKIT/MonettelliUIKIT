using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PancakeView;
using Xamarin.Forms.Xaml;

namespace $safeprojectname$.Views.ShellTemplates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutHeaderTemplate : PancakeView
    {
        public FlyoutHeaderTemplate()
        {
            InitializeComponent();
        }
    }
}