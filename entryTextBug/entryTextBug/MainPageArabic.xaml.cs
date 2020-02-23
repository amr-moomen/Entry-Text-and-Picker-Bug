using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace entryTextBug
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageArabic : ContentPage
    {
        public MainPageArabic()
        {
            InitializeComponent();         
            List<string> items = new List<string>() { "ذكر", "انثى" };
            GenderPicker.ItemsSource = items;
            GenderPicker.SelectedItem = items[0];
            GenderPicker.SelectedIndex = 0;

        }
        private void ChangeLangugeClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}