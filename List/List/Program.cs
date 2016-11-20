using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            numbers.Add(1);

            numbers.AddRange(new int[] { 2, 3 });

            Console.WriteLine(numbers.Count);

            //numbers.Clear();
            //Console.WriteLine(numbers.Count);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine("{0} =  {1}", i, numbers[i]);
            }
            
            Console.ReadKey();
        }
    }
}
