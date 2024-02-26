namespace leap_year
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int currentYear = DateTime.Now.Year;
            int leapYearCount = 0;

            Console.WriteLine("The next 20 leap years are:");

            while (leapYearCount < 20)
            {
                int nextLeapYear = GetNextLeapYear(currentYear);
                Console.WriteLine(nextLeapYear);
                currentYear = nextLeapYear;
                leapYearCount++;
            }
        }

        public static int GetNextLeapYear(int year)
        {
            while (true)
            {
                year++;

                if (IsLeapYear(year))
                {
                    return year;
                }
            }
        }

        public static bool IsLeapYear(int year)
        {
            if (year % 4 != 0)
            {
                return false;
            }
            else if (year % 100 != 0)
            {
                return true;
            }
            else if (year % 400 != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
