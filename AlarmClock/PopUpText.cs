using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    public class PopUpText
    {
        public string message { get; set; }

        public PopUpText(string text)
        {
            message = text;
        }
        public string PopUp(string text)
        {
            message = text;
            return message;
        }
    }
}
