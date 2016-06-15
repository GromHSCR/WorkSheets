using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Worksheets.ViewModels
{
    public class ColorSelectionViewModel
    {
        public List<Color> Colors { get; set; }

        public List<string> ColorNames { get; set; }

        public ColorSelectionViewModel()
        {
            Colors = new List<Color>
            {
                Color.Yellow,
                Color.Red,
                Color.White,
                Color.Black,
                Color.Blue,
                Color.Green,
                Color.Gray,
                Color.Pink,
                Color.Purple,
                Color.Olive,
                Color.Aqua,
                Color.Fuchsia,
                Color.Lime,
                Color.Maroon,
                Color.Navy
            };
            ColorNames = Colors.Select(p => p.ToString()).ToList();
        }
    }
}
