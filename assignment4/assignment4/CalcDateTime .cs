using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    static class CalcDateTime
    {
        public static int DateDif(DateTime date1, DateTime date2)
        {
            TimeSpan diff = date1 - date2;
                return (int)diff.TotalDays;
        }
        public static DateTime AddDayToDate(DateTime date, uint numofdate)
        {
            return date.AddDays(numofdate);
        }
    }
}
