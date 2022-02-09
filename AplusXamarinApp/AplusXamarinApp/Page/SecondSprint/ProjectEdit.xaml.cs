using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AplusXamarinApp.Page.InformationProjectPage;
using AplusXamarinApp.Page.SecondSprint;
using AplusXamarinApp.Page;
using AplusXamarinApp;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AplusXamarinApp.Models;
using AplusXamarinApp.Data;
using AplusXamarinApp.transfer;

namespace AplusXamarinApp.Page.SecondSprint
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectEdit : ContentPage
    {
        public ProjectEdit()
        {
            InitializeComponent();
           
        }
        string titles = GiveTitleProject.PTitle;

        private async void BChange_Clicked(object sender, EventArgs e)
        {
            
            bool result = await DisplayAlert("Подтвердить действие", $"Вы точно хотите изменить {titles} ?", "Да", "Нет");
           // if (result == true) { await Navigation.PushAsync(new InformationProjectPage()); }
            //var friend = (User)BindingContext;
            //if (!String.IsNullOrEmpty(friend.UserEmail))
            //{
            //    App.Database.SaveItem(friend);
            //}

        }

        private async void BRemove_Clicked(object sender, EventArgs e)
        {

            await Navigation.PopAsync();
            
        }

        private async void TEditingProject_Clicked(object sender, EventArgs e)
        {
           
            bool result = await DisplayAlert("Подтвердить действие", $"Вы точно хотите удалить {titles}?", "Да", "Нет");
            if(result == true ) { await Navigation.PushAsync(new MainPage()); }
            else { await Navigation.PopAsync(); }
            //await Navigation.PushAsync(new MainPage());
        }
    }
}