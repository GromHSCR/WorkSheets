using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheets.ViewModels
{
    public class HelpViewModel 
    {
        public List<string> HelpItemsList { get; set; }

        public HelpViewModel()
        {
            HelpItemsList = new List<string>
            {
                "View and create worksheets on your iPhone oriPad",
                "Use Edit worksheets on your iPhone or iPad"
            };
        }
    }
}
