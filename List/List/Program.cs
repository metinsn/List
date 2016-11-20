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
            #region ornek1

            //List<int> numbers = new List<int>();

            //numbers.Add(1);

            //numbers.AddRange(new int[] { 2, 3 });

            //Console.WriteLine(numbers.Count);

            //Console.WriteLine();

            ////numbers.Clear();
            ////Console.WriteLine(numbers.Count);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine("{0} =  {1}", i, numbers[i]);
            //}

            //Console.ReadKey();


            #endregion


            #region ornek2

            //int[] array = new int[2];
            //array[0] = 3;
            //array[1] = 5;

            //List<int> list = new List<int>(array);

            //Console.WriteLine("Boyut: "+ list.Count);

            //Console.WriteLine("Elemanlar : ");
            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.ReadKey();

            #endregion ornek3

            List<int> numbers = new List<int>(new int[] {1903,1904,1905,1907});

            int index = numbers.IndexOf(1905);
            Console.WriteLine("sırası : " + index);

            index = numbers.IndexOf(1907);
            Console.WriteLine("sırası : " + index);

            Console.ReadKey();

        }
    }
}
