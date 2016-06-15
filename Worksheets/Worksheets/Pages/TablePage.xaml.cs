using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Worksheets.Pages
{
    public partial class TablePage : ContentPage
    {
        public ColumnDefinitionCollection ColumnCollection { get; set; }
        public RowDefinitionCollection RowCollection { get; set; }
        public TablePage()
        {
            InitializeComponent();
            GridTable.Padding = new Thickness(1);
            ColumnCollection = new ColumnDefinitionCollection();
            RowCollection = new RowDefinitionCollection();
            for (int i = 0; i < 20; i++)
            {
                ColumnCollection.Add(new ColumnDefinition() { Width = 80 });
                RowCollection.Add(new RowDefinition() { Height = 40 });
            }
            GridTable.ColumnDefinitions = ColumnCollection;
            GridTable.RowDefinitions = RowCollection;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        GridTable.Children.Add(new Label()
                        {
                            BackgroundColor = Color.FromHex("#f6f0ec"),
                        }, i, j);
                    }
                    else if (i == 0)
                    {
                        var month = DateTime.Now.Month + j;
                        if (month % 12 > 0)
                            month = month % 12;
                        else
                        {
                            month = 12;
                        }
                        var date = new DateTime(2016, month, 17);
                        GridTable.Children.Add(new Label()
                        {
                            Text = date.ToString("MMM-dd"),
                            BackgroundColor = Color.FromHex("#f6f0ec"),
                            VerticalOptions = LayoutOptions.Fill,
                            HorizontalOptions = LayoutOptions.Fill,
                        }, i, j);
                    }
                    else if (j == 0)
                    {
                        GridTable.Children.Add(new Entry()
                        {
                            Text = string.Format("test{0}_{1}", i, j),
                            BackgroundColor = Color.FromHex("#f6f0ec"),
                            VerticalOptions = LayoutOptions.Fill,
                            HorizontalOptions = LayoutOptions.Fill,

                        }, i, j);
                    }
                    else
                    {
                        GridTable.Children.Add(new Entry()
                        {
                            Text = (i + j).ToString(),
                            Keyboard = Keyboard.Numeric,
                            BackgroundColor = Color.White,
                            VerticalOptions = LayoutOptions.Fill,
                            HorizontalOptions = LayoutOptions.Fill,
                        }, i, j);
                    }
                }
            }

        }

        private async void MenuItem_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ColorSelectionPage());
        }

        private async void MenuItem1_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FormulaPage());
        }
    }
}
