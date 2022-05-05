using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwn_Lambdas_FindAll_Where
{
    class Program
    {
        static void Main()
        {
            List<int> startList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Find all even numbers - first solution
            // List<int> evenList = startList.FindAll(delegate (int x) { return x % 2 == 0; });

            // Find all even numbers - better solution
            List<int> evenList = startList.FindAll((int x) => x % 2 == 0);

            // Find all odd numbers - another solution
            List<int> oddList = startList.Where(x => x % 2 == 1).ToList();

            Console.WriteLine("evenList is:");
            foreach (var item in evenList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("oddList is:");
            oddList.ForEach(x => Console.WriteLine(x)); // another approach to loop through each element of that list.

            Console.ReadKey();
        }
    }
}
