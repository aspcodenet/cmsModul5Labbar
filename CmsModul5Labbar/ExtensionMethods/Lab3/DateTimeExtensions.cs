using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsModul5Labbar.ExtensionMethods.Lab3
{
    static class DateTimeExtensions
    {
        public static DateTime GetLastDateOfMonth(this DateTime currentDate)
        {
            int monthDays = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
            int datediff = monthDays - currentDate.Day;
            return currentDate.AddDays(datediff);
        }
    }
}
