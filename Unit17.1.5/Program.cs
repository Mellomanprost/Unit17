using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit17._1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            DailyAverage();
            WeeklyAverage();
            MonthlyAverage();
        }

        private static void DailyAverage()
        {
            Console.WriteLine(
                $"{Constants.Welcome} day {Constants.LineBreak}{Constants.Forecast} {new Random().Next(10, 30)}{Constants.LineBreak}");
        }

        private static void WeeklyAverage()
        {
            Console.WriteLine(
                $"{Constants.Welcome} week {Constants.LineBreak}{Constants.Forecast} {new Random().Next(10, 35)} {Constants.LineBreak}");
        }

        private static void MonthlyAverage()
        {
            Console.WriteLine(
                $"{Constants.Welcome} month {Constants.LineBreak}{Constants.Forecast} {new Random().Next(10, 40)} {Constants.LineBreak}");
        }
    }
}
