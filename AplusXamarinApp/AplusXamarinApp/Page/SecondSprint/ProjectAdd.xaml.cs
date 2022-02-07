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



namespace AplusXamarinApp.Page.SecondSprint
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectAdd : ContentPage
    {
        public ProjectAdd()
        {
            InitializeComponent();
        }

        private async void BRemove_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SelectPeojectPage());
        }

        private void BAddProjece_Clicked(object sender, EventArgs e)
        {

        }
    }
}