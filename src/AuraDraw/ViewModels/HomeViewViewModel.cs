using System;
using System.Collections.Generic;
using System.Text;

namespace AuraDraw.ViewModels
{
    public class HomeViewViewModel : ViewModelBase
    {
        public string CurrentGreeting { get => GetGreeting(); }

        public string GetGreeting()
        {
            var dt = Int32.Parse(DateTime.Now.ToString("HH"));
            if(0 <= dt && dt < 12)
            {
                return "Good Morning";
            }
            else if(12 <= dt && dt < 18)
            {
                return "Good Afternoon";
            }
            else if (18 <= dt && dt <= 23)
            {
                return "Good Night";
            }
            else
            {
                return "Good Night";
            }
        }
    }
}
