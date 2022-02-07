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


namespace AplusXamarinApp.Page.InformationProjectPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InformationProjectPage : ContentPage
    {
        public InformationProjectPage()
        {
            InitializeComponent();
        }

        private async void TEditing_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProjectEdit());
        }


    }
}