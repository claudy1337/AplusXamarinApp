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
            EPhoneOne.Text = GiveTitleProject.Number;
            EEmail.Text = GiveTitleProject.Email;
            EAddress.Text = GiveTitleProject.Address;
            ProjectName.Text = GiveTitleProject.PTitle;
            
        }
        string titles = GiveTitleProject.PTitle;
        string ProjectContent = GiveTitleProject.Content;
        private async void BChange_Clicked(object sender, EventArgs e)
        {
            
            //bool result = await DisplayAlert("Подтвердить действие", $"Вы точно хотите изменить {titles} ?", "Да", "Нет");
            //var friend = (Project)BindingContext;
            //if (!String.IsNullOrEmpty(friend.ProjectTitle))
            //{
            //    App.PDatabase.SaveItem(friend);
            //}

            //this.Navigation.PopAsync();
        }

        private async void BRemove_Clicked(object sender, EventArgs e)
        {

            await Navigation.PopAsync();
            
        }

        private async void TEditingProject_Clicked(object sender, EventArgs e)
        {
           
            bool result = await DisplayAlert("Подтвердить действие", $"Вы точно хотите удалить {titles}?", "Да", "Нет");
            
                //var friend = (Project)BindingContext;
                //App.Database.DeleteItem(friend.Id);
                this.Navigation.PushAsync(new SelectPeojectPage());
            //await Navigation.PushAsync(new MainPage());
        }
    }
}