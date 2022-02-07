using System;
using Xamarin.Forms;
using System.IO;
using Xamarin.Forms.Xaml;
using AplusXamarinApp.Page;
using AplusXamarinApp.Models;
using AplusXamarinApp.Data;

namespace AplusXamarinApp
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "user.db";
        internal static UserBD database;
        internal static UserBD Database
        {
            get
            {
                if(database == null)
                {
                    database = new UserBD(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));

                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
