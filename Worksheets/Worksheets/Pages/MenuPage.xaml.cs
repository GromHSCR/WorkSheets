using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksheets.ViewModels;
using Xamarin.Forms;

namespace Worksheets.Pages
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
            BindingContext = new MenuViewModel();

            MenuMainImage.Source = ImageSource.FromResource("Worksheets.Logo.png");
            // create an array of the Page names
            

            this.MainMenuList.ItemSelected += (sender, args) =>
            {
                var selectedItem = MainMenuList.SelectedItem.ToString();
                var mainPage = ((ListViewPage) App.Current.MainPage);
                var currentPageDetail = mainPage.Detail;
                // Set the BindingContext of the detail page.
                if (selectedItem == "Worksheets")
                {
                    if (currentPageDetail.GetType() != typeof(WorkSheetsPage))
                        mainPage.Detail = new NavigationPage(new WorkSheetsPage())
                        {
                            BarBackgroundColor = Color.Red
                        };
                }else
                if (selectedItem == "Support")
                {
                    if (currentPageDetail.GetType() != typeof(HelpPage))
                        mainPage.Detail = new NavigationPage(new HelpPage());
                }
                else
                if (selectedItem == "Log Out")
                {
                    App.Current.MainPage = new NavigationPage(new AuthPage());
                }
            };
        }
    }
}
