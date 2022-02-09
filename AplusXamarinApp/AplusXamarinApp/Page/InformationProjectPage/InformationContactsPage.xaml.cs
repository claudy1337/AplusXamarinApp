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



namespace AplusXamarinApp.Page.InformationProjectPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InformationContactsPage : ContentPage
    {
        public InformationContactsPage()
        {
            InitializeComponent();
        }

        private async void TEditingContacts_Clicked(object sender, EventArgs e)
        {
            User friend = new User();
            ProjectAdd friendPage = new ProjectAdd();
            friendPage.BindingContext = friend;
            await Navigation.PushAsync(friendPage);

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
    }
}