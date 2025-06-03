using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class DelegatesFunctions
    {
        public static void showVersion()
        {
            Console.WriteLine("App Version: 25.2.4.4480");
        }

        public static void countLowerCase()
        {
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();
            int count = 0;

            foreach (char c in input)
            {
                if (char.IsLower(c))
                {
                    count++;
                }
            }

            Console.WriteLine($"There are {count} lowercase letters in your text.");
        }

        public static void showTime()
        {
            Console.WriteLine($"Current Time is {DateTime.Now:HH:mm}");
        }

        public static void showDate()
        {
            Console.WriteLine($"Current Date is {DateTime.Now:yyyy-MM-dd}");
        }
    }
}
