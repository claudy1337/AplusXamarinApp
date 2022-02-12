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
using AplusXamarinApp.transfer;



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
           await Navigation.PushAsync(new ProjectEdit());
        }

        protected override void OnAppearing()
        {
            
        }
        //public void SendInfornmation()
        //{
        //    GiveTitleProject.Address = EAddress.Text;
        //    GiveTitleProject.Email = EEmail.Text;
        //    GiveTitleProject.Number = EPhoneOne.Text;
        //}
    }
}