using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KellyTestProject.AppCode
{
    public static class Helper
    {
        public static DateTime GetRandomDate()
        {
            var random = new Random();
            int year = random.Next(2017, 2022);
            int month = random.Next(1, 13);
            int days = random.Next(1, DateTime.DaysInMonth(year, month) + 1);
            return new DateTime(year, month, days, random.Next(0, 24), random.Next(0, 60), random.Next(0, 60));
        }
    }
}
