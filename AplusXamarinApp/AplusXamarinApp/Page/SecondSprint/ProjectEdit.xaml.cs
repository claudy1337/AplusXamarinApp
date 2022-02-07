using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AplusXamarinApp.Page.InformationProjectPage;
using AplusXamarinApp.Page.SecondSprint;
using AplusXamarinApp.Page;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AplusXamarinApp.Page.SecondSprint
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectEdit : ContentPage
    {
        public ProjectEdit()
        {
            InitializeComponent();
        }

        private void BChange_Clicked(object sender, EventArgs e)
        {

        }

        private void BRemove_Clicked(object sender, EventArgs e)
        {

        }

        private async void TEditingProject_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}