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
            friday,
            saturday,
            sunday
        }
        static void Main(string[] args)
        {

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("What if your favorite day of week?");
            DayOfWeek MyFavoriteDay = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("Your name is {0} and age is {1} and your favorite day of week {2} ", name, age, MyFavoriteDay);
            Console.ReadKey();
        }
    }
}
