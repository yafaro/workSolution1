using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketClassLibrary1
{
    public static class Class1
    {
        public static bool StockMarketTine(DateTime dt)
        {
            if (dt.DayOfWeek >= DayOfWeek.Monday
                && dt.DayOfWeek <= DayOfWeek.Friday
                && dt.TimeOfDay >= TimeSpan.FromHours(9)
                && dt.TimeOfDay <= TimeSpan.FromMinutes(13.5))
            {
                return true;
            }
            else
            {
                return false;
            }    
            
             
            }  

            
            
            
        }
    }


    

