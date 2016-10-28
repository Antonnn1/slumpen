using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slumpen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övn 1
            Random rand = new Random();
            int summa = 0;
            for (int i = 0; i < 10; i++)
            {
                int tal = rand.Next(1, 20);
                Console.WriteLine(tal);
                summa = summa + tal;
            }
            Console.WriteLine("Medelvärdet blir: " + (summa/10));
        }
    }
}

