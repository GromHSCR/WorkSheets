using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksheets.Models;
using Worksheets.ViewModels;
using Xamarin.Forms;

namespace Worksheets.Pages
{
    public partial class ListViewPage : MasterDetailPage
    {
        public ListViewPage()
        {
            InitializeComponent();

            this.Master = new MenuPage();

            this.Detail = new NavigationPage(new WorkSheetsPage())
            {
                BarBackgroundColor = Color.Red
            };
        }
    }
}
