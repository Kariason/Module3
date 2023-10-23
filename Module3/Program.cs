using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
    internal class Program
    {
        enum DayOfWeek : byte
        {
            monday = 1,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            var age = checked((byte)int.Parse(Console.ReadLine()));

            Console.WriteLine("Your name is {0} and age is {1} ", name, age);

            Console.Write("What is your favorite day of week? ");
            var day = (DayOfWeek)int.Parse(Console.ReadLine());

            Console.WriteLine("Your favorite day is {0}", day);
        }
    }
}
