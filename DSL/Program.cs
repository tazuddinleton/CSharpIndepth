using System;
using System.Diagnostics.Tracing;

namespace DSL
{

    public static class IntExtensions
    {
        public static TimeSpan Minutes(this int value)
        {
            return TimeSpan.FromMinutes(value);
        }

        public static bool IsGreaterThan(this int value, int lowerValue)
        {
            return value.CompareTo(lowerValue) > 0;
        }
    }

    public static class TimeSpanExtensions
    {
        public static DateTime FromNow(this TimeSpan value)
        {
            return DateTime.Now.Add(value);
        }
    }
     
    class Program
    {
        static void Main(string[] args)
        {
            var duration = 7.Minutes();

            var when = 15.Minutes().FromNow();

            var tomsAge = 45;
            var harrysAge = 85;

            if (tomsAge.IsGreaterThan(harrysAge))
            {

            }


            Console.WriteLine("Hello World!");
        }
    }
}
