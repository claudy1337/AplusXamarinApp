﻿using System;
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
            var friend = (User)BindingContext;
            if (!String.IsNullOrEmpty(friend.UserPhoneOne))
            {
                App.Database.SaveItem(friend);
            }
           
            //await Navigation.PushAsync(new ProjectEdit());
            await Navigation.PushAsync(new ProjectEdit());
            
        }
       
    }
}