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
using AplusXamarinApp.Models;
using AplusXamarinApp.Data;
using AplusXamarinApp.transfer;



namespace AplusXamarinApp.Page.SecondSprint
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectAdd : ContentPage
    {
        private User _user;
        private UserBD _userbd;
        public ProjectAdd()
        {
            InitializeComponent();
        }
        string titles = GiveTitleProject.PTitle;
        private async void BRemove_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        
        private async void BAddProjece_Clicked(object sender, EventArgs e)
        {

            bool result = await DisplayAlert("Подтвердить действие", $"Вы точно хотите добавить {titles}?", "Да", "Нет");
            await Navigation.PopAsync();

        }
    }
}