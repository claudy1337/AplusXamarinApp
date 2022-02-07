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


namespace AplusXamarinApp.Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectPeojectPage : ContentPage
    {
        public List<string> LVProjectsName { get; set; }
        public SelectPeojectPage()
        {
            InitializeComponent();
            LVProjectsName = new List<string>();
            FillList();
            this.BindingContext = this;
        } //TEXT = "&#X"

        public void FillList()
        {
            for (int i = 0; i < 18; i++)
            {
                LVProjectsName.Add($"Проект {i + 1}");
            }
        }

        private async void AddProject_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProjectAdd());
        }

        private async void LWSelectPeoject_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new SelectedProjectPage(LWSelectPeoject.SelectedItem.ToString()));
        }
    }
}