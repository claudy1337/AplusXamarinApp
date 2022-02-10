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
    public partial class InformationProjectPage : ContentPage
    {
        public InformationProjectPage()
        {
            InitializeComponent();
           
           
        }

        private async void TEditing_Clicked(object sender, EventArgs e)
        {
            User friend = new User();
            ProjectEdit friendPage = new ProjectEdit();
            friendPage.BindingContext = friend;
            await Navigation.PushAsync(new ProjectEdit());
            
        }
        protected override void OnAppearing()
        {
            friendsList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }

        private async void friendsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            User selectedFriend = (User)e.SelectedItem;
            ProjectEdit friendPage = new ProjectEdit();
            friendPage.BindingContext = selectedFriend;
            await Navigation.PushAsync(friendPage);
        }
    }
}