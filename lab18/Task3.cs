using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18
{
    internal class Task3
    {
        public static void Run()
        {
            List<Automobile> salone1 = new List<Automobile>()
            {
                new Automobile("Audi S5", "Audi", 2018),
                new Automobile("Toyota X4", "Toyota", 2020),
                new Automobile("Camri 3X5", "Camri", 2021),
                new Automobile("Volkswagen golf", "Volkswagen", 1974),
                new Automobile("Hyundai solaris", "Hyundai", 2012),
            };

            List<Automobile> salone2 = new List<Automobile>()
            {
                new Automobile("Audi A8", "Audi", 2022),
                new Automobile("Volkswagen Passat", "Volkswagen", 2006),
                new Automobile("Honda Civic", "Honda", 1979),
                new Automobile("Subaru BRZ", "Subaru", 2013),
            };
            Console.WriteLine("\nSalone1 cars:");
            Task1.Show(salone1, "\n");
            Console.WriteLine("\nSalone2 cars:");
            Task1.Show(salone2, "\n");
            
            //all comparisons are produced by Automobile.Manufacturer field

            Console.WriteLine("\nCars from salone1 which aren't in salone2:");
            Task1.Show(salone1.Where(car => salone2.Exists(elem => elem.Manufacturer == car.Manufacturer) == false).ToList(), "\n");

            Console.WriteLine("\nCars from salone1 which are in salone2:");
            Task1.Show(salone1.Where(car => salone2.Exists(elem => elem.Manufacturer == car.Manufacturer) == true).ToList(), "\n");

            Console.WriteLine("\nCars from salone1 and salone2(without reps):");
            Task1.Show(salone1.Concat(salone2).DistinctBy(car => car.Manufacturer).ToList(), "\n");
        }
    }

    internal struct Automobile
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int ProductionYear { get; set; }

        public Automobile(string name, string manufacturer, int year)
        {
            Name = name;
            Manufacturer = manufacturer;
            ProductionYear = year;
        }

        public Automobile() : this(string.Empty, string.Empty, 0)
        { }

        public override string ToString()
        {
            return $"Name: {Name}, Manufacturer: {Manufacturer}, Production year: {ProductionYear}";
        }
    }
}
