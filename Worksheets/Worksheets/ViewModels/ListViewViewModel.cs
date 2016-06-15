using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksheets.Models;
using Xamarin.Forms;

namespace Worksheets.ViewModels
{
    public class ListViewViewModel
    {
        public List<ListViewItemModel> WorkSheets { get; set; }

        public ImageSource Clone { get; set; }

        public ImageSource Rename { get; set; }

        public ImageSource Remove { get; set; }

        public ImageSource ImageIcon { get; set; }

        public ImageSource More { get; set; }

        public ListViewViewModel()
        {
            WorkSheets = new List<ListViewItemModel>();
            for (int i = 0; i < 30; i++)
            {
                WorkSheets.Add(new ListViewItemModel()
                {
                    Name = string.Format("WorkSheet {0}", i),
                    Modified = new DateTime(2016, 5, 23),
                });
            }

            ImageIcon = ImageSource.FromResource("Worksheets.paint-palette-and-brush.png");
            Clone = ImageSource.FromResource("Worksheets.copy.png");
            Rename = ImageSource.FromResource("Worksheets.edit.png");
            Remove = ImageSource.FromResource("Worksheets.rubbish-bin.png");
            More = ImageSource.FromResource("Worksheets.more.png");
        }
    }
}
