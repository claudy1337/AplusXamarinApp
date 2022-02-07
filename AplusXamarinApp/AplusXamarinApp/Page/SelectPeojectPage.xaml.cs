using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AplusXamarinApp.Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectPeojectPage : ContentPage
    {
        public List<string> Projects { get; set; }
        public SelectPeojectPage()
        {
            InitializeComponent();
            Projects = new List<string>();
            FillList();
            this.BindingContext = this;
        }

        private async void LWSelectPeoject_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new SelectedProjectPage(LWSelectPeoject.SelectedItem.ToString()));
        }
        public void FillList()
        {
            for (int i = 0; i < 18; i++)
            {
                Projects.Add($"Проект {i + 1}");
            }
        }
    }
}