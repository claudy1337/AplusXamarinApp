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

namespace AplusXamarinApp.Page.SecondSprint
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectEdit : ContentPage
    {
        public ProjectEdit()
        {
            InitializeComponent();
           
        }
        protected override void OnAppearing()
        {
            EPhoneOne.Text = App.Database.ToString();
            base.OnAppearing();
        }

        private void BChange_Clicked(object sender, EventArgs e)
        {
            var friend = (User)BindingContext;
            if (!String.IsNullOrEmpty(friend.UserEmail))
            {
                App.Database.SaveItem(friend);
            }
            this.Navigation.PopAsync();
        }

        private void BRemove_Clicked(object sender, EventArgs e)
        {

        }

        private async void TEditingProject_Clicked(object sender, EventArgs e)
        {
           
            bool result = await DisplayAlert("Подтвердить действие", $"Вы точно хотите удалить ?", "Да", "Нет");
            await DisplayAlert("Уведомление", "Вы выбрали: " + (result ? "Удалить" : "Отменить"), "OK");
            //await Navigation.PushAsync(new MainPage());
        }
    }
}