using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Здравствуйте! Введите Ваше имя: ");
            var name = Console.ReadLine();

            Console.Write("Введите Ваш возраст: ");
            var age = int.Parse(Console.ReadLine());

            Console.Write("Введите Вашу дату рождения: ");
            var birthdate = Console.ReadLine();

            Console.WriteLine("Ваше имя - {0}.\nВаш возраст - {1}.\nВы родились - {2}", name, age, birthdate);
        }
    }
}
