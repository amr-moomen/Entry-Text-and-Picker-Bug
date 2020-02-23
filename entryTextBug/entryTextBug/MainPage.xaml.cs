using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace entryTextBug
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            List<string> items = new List<string>() { "Male","Female" };
          

            GenderPicker.ItemsSource = items;
            GenderPicker.SelectedItem = items[0];
            GenderPicker.SelectedIndex = 0;
        }

        private void ChangeLangugeClicked(object sender, EventArgs e)
        {

            App.Current.MainPage = new NavigationPage(new MainPageArabic());

        }
    }
}
