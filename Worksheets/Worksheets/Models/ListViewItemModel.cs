using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Worksheets.Models
{
    public class ListViewItemModel
    {
        public string Name { get; set; }

        public DateTime Modified { get; set; }

        public string ModifiedAsString
        {
            get { return Modified.ToString("dd MM yyyy"); }
        }
    }
}
