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
using AplusXamarinApp.Data;
using AplusXamarinApp.Models;
using AplusXamarinApp.transfer;



namespace AplusXamarinApp.Page.InformationProjectPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InformationContactsPage : ContentPage
    {
        public InformationContactsPage()
        {
            InitializeComponent();
            EPhoneOne.Text = "88000";
            EEmail.Text = "mail@mail.ru";
            EAddress.Text = "Galeeva 3";
            SendInfornmation();
        }

        private async void TEditingContacts_Clicked(object sender, EventArgs e)
        {

            SendInfornmation();
            User friend = new User();
            ProjectEdit friendPage = new ProjectEdit();
            friendPage.BindingContext = friend;
            await Navigation.PushAsync(new ProjectEdit());

        }

        protected override void OnAppearing()
        {
            
        }

        private async void friendsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            User selectedFriend = (User)e.SelectedItem;
            ProjectAdd friendPage = new ProjectAdd();
            friendPage.BindingContext = selectedFriend;
            await Navigation.PushAsync(friendPage);
        }
        public void SendInfornmation()
        {
            GiveTitleProject.Address = EAddress.Text;
            GiveTitleProject.Email = EEmail.Text;
            GiveTitleProject.Number = EPhoneOne.Text;
        }
    }
}