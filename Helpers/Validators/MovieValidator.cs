using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAppWorkshop.Helpers
{
    public class MovieValidator 
    {
        public static bool ValidateTitle (string title)
        {
            if (title != string.Empty || string.Empty == null)
            {
                return true;
            }
            return false;
        }
    }
}
