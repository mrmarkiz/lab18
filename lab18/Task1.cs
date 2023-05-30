using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace lab18
{
    internal class Task1
    {
        public static void Run()
        {
            List<string> strings = new List<string>()
            {
                "example string",
                "midium-sixed string",
                "short one",
                "quite long string",
                "avarage length string",
                "some words",
                "nothing",
                "why?"
            };
            int choice;
            do
            {
                Console.WriteLine("Enter what to do(1-order descending, 2-order ascending):");
                if (!int.TryParse(Console.ReadLine(), out choice))
                    break;
                switch (choice)
                {
                    case 1:
                        strings = strings.OrderByDescending(str => str.Length).ToList();
                        break;
                    case 2:
                        strings = strings.OrderByDescending(str => str.Length).ToList();
                        strings.Reverse();
                        break;
                }
                Console.WriteLine("Current array:");
                Show(strings);
            } while (true);
        }
        public static void Show<T>(List<T> array)
        {
            Console.WriteLine(string.Join("\n", array));
        }
    }
}
