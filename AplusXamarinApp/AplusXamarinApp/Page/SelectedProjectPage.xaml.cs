using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AplusXamarinApp.Page.InformationProjectPage;
using AplusXamarinApp.Page.SecondSprint;
using AplusXamarinApp.Page;
using AplusXamarinApp;


namespace AplusXamarinApp.Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectedProjectPage : TabbedPage
    {
        public SelectedProjectPage(string projects)
        {
            InitializeComponent();
            Title = projects;
        }
    }
}