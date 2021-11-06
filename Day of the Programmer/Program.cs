//Finished in 15 minutes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_of_the_Programmer
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
             
            string result = dayOfProgrammer(year);
            Console.WriteLine(result);
        }
        static string dayOfProgrammer(int year)
        {
            if (year == 1918)
                return "26.09." + year.ToString();
            else if ((year < 1918 && (year % 4 == 0)) || ((year > 1918) && (year % 4 == 0 & year % 100 != 0) || (year % 400 == 0)))
                return "12.09." + year.ToString();
            else
                return "13.09." + year.ToString() ;

        }
    }
}
