using System;

namespace Identify_Leap_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 0;
            year = int.Parse(Console.ReadLine());

            if ((year % 4==0) && (year% 100!=0) || (year % 400 == 0))
            {
                Console.WriteLine("{0} is a Leap Year ", year);
            }

            else
            
            {
            Console.WriteLine("{0} is not a Leap Year", year);
            }
            Console.ReadKey();


        }
             
    }
}
