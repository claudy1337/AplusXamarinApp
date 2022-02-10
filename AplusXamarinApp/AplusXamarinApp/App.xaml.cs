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
        public const string PDATABASE_NAME = "project.db";
        internal static UserBD Userdatabase;
        internal static ProjectBD Projectdatabase;
        internal static UserBD Database
        {
            get
            {
                if(Userdatabase == null)
                {
                    Userdatabase = new UserBD(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));

                }
                return Userdatabase;
            }
        }
        internal static ProjectBD PDatabase
        {
            get
            {
                if (Projectdatabase == null)
                {
                    Projectdatabase = new ProjectBD(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), PDATABASE_NAME));

                }
                return Projectdatabase;
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
