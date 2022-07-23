using System;

namespace Csharp_Working_9_5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            program();
        }
        public static void program()
        {
            try { 
            Console.WriteLine("Start Time:");
            string start_time = Console.ReadLine();
            Console.WriteLine("End Time:");
            string end_time = Console.ReadLine();
            Console.WriteLine("Hourly Rate:");
            string hourly_rate = Console.ReadLine();
            Console.WriteLine("Overtime Multiplier:");
            string overtime_multiplier = Console.ReadLine();

            overtime(start_time, end_time, hourly_rate, overtime_multiplier);
            }
            catch (Exception e)
            {
                program();
            }
        }

        public static void overtime(string start_time, string end_time, string hourly_rate, string overtime_multiplier)
        {
            decimal start_time_dec = decimal.Round(Decimal.Parse(start_time), 2, MidpointRounding.AwayFromZero);
            decimal end_time_dec = decimal.Round(Decimal.Parse(end_time), 2, MidpointRounding.AwayFromZero);
            decimal hourly_rate_dbl = decimal.Round(Decimal.Parse(hourly_rate), 2, MidpointRounding.AwayFromZero);
            decimal overtime_multi_dbl = decimal.Round(Decimal.Parse(overtime_multiplier), 2, MidpointRounding.AwayFromZero);

            if (end_time_dec <= 17)
            {
                decimal hours_working = end_time_dec - start_time_dec;
                decimal pay = hours_working * hourly_rate_dbl;
                Console.WriteLine(pay);
            }
            else if (end_time_dec > 17)
            {
                decimal hours_working = 17 - start_time_dec;
                decimal pay = hours_working * hourly_rate_dbl;

                decimal hours_overtime_dec = end_time_dec - 17;
                decimal overtime_rate_dec = Decimal.Multiply(hourly_rate_dbl, overtime_multi_dbl);
                decimal final_pay = pay + (hours_overtime_dec * overtime_rate_dec);
                Console.WriteLine("$" + final_pay);
                Console.ReadKey();
            }
        }
    }
}