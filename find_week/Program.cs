using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace find_week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*CDB = current business date
             NBD = Next business date*/

            DateTime CBD = Convert.ToDateTime("4/11/2024");
            DateTime NBD = Convert.ToDateTime("4/15/2024");

            /*Console.WriteLine(GetIso8601WeekOfYear(CBD));
            Console.WriteLine(GetIso8601WeekOfYear(NBD));
            Console.WriteLine(IsWeekEnd(CBD, NBD));*/

            string dates = $"Current business date = {CBD}, \nNext business date = {NBD}";
            Console.WriteLine(dates);

            string output = "";
            if(IsWeekEnd(CBD, NBD))
                output = $"{CBD} is the last weekday of the week";
            else
                output = $"{CBD} is not last weekday of the week";
            Console.WriteLine(output);

            Console.ReadKey();
        }

        public static int GetIso8601WeekOfYear(DateTime time)
        {   
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Sunday);
        }

        private static bool IsWeekEnd(DateTime CBD, DateTime NBD)
        {
            if (GetIso8601WeekOfYear(CBD) != GetIso8601WeekOfYear(NBD))
                return true;
            else
                return false;
        }
    }
}
