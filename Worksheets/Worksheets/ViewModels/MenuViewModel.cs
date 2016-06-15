using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheets.ViewModels
{
    public class MenuViewModel
    {
        public List<string> MenuItems { get; set; }

        public MenuViewModel()
        {
            MenuItems = new List<string>{
               "Worksheets",
               "Support",
               "Log Out",
             };
        }
    }
}
