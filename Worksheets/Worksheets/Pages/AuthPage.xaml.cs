using System;
using System.Reflection;
using Xamarin.Forms;

namespace Worksheets.Pages
{
    public partial class AuthPage : ContentPage
    {
        public AuthPage()
        {
            InitializeComponent();
            LogoImage.Source = ImageSource.FromResource("Worksheets.Logo.png");
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new ListViewPage();
        }
    }
}
