using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksheets.ViewModels;
using Xamarin.Forms;

namespace Worksheets.Pages
{
    public partial class ColorSelectionPage : ContentPage
    {
        public ColorSelectionPage()
        {
            InitializeComponent();
            BindingContext = new ColorSelectionViewModel();
        }
    }
}
