using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TabbedDontUseMyApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]

    public partial class MainPage : TabbedPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }
        public static class GlobalVariables
        {
            public static string selectedUrl;
            public static string selectedName;
        }
    }
}
