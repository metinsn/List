using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> liste = new List<String>();
            liste.Add("123");
            liste.Add("856498");
            liste.Add("5656");
            foreach (String i in liste)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

        }
    }
}
