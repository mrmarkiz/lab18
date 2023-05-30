using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18
{
    internal class Task2
    {
        public static void Run()
        {
            List<int> array1 = new List<int>()
            {
                0,1,2,8,4,5,7,6,7,8,9,0
            };
            List<int> array2 = new List<int>()
            {
                2,4,7,12,10
            };

            Console.WriteLine("Array1:");
            Task1.Show(array1, ", ");
            Console.WriteLine("Array2:");
            Task1.Show(array2, ", ");
            
            Console.WriteLine("\nElement of arr1 which aren't in arr2:");
            Task1.Show(array1.Where(el => array2.Exists(elem => elem == el) == false).ToList(), ", ");
            
            Console.WriteLine("\nIncommon elements for two arrays:");
            Task1.Show(array1.Distinct().Where(el => array2.Exists(elem => elem == el) == true).ToList(), ", ");

            Console.WriteLine("\nUnification of two arrays(without reps):");
            Task1.Show(array1.Concat(array2).Distinct().ToList(), ", ");

            Console.WriteLine("\nFirst array elements without reps:");
            Task1.Show(array1.Distinct().ToList(), ", ");
        }
    }
}
