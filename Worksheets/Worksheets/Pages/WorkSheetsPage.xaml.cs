using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksheets.ViewModels;
using Xamarin.Forms;

namespace Worksheets.Pages
{
    public partial class WorkSheetsPage : ContentPage
    {
        public WorkSheetsPage()
        {
            InitializeComponent();

            this.BindingContext = new ListViewViewModel();
        }


        private void MenuItem_OnClicked(object sender, EventArgs e)
        {
            ((ListViewPage)App.Current.MainPage).Detail = new NavigationPage(new TablePage()
            {
                Title = MainListView.SelectedItem.ToString()
            }){
                BarBackgroundColor = Color.Red,
            };
        }

        private async void Palette_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new ColorCodePage()));
        }
    }
}
