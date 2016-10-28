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
            random rand = new random();
            int summa = 0;
            int tal;
            for (int i = 0; i < 10; i++)
            {
                tal = rand.next(1, 20);
                console.writeline(tal);
                summa = summa + tal;
            }
            console.writeline("medelvärdet blir: " + (summa / 10));

            /*
            //Övn 2
            Random rand = new Random();
            int[] minArray; 
            
            for (int i = 0; i < 20; i++)
            {
                int tal = rand.Next(15, 30);
                Console.WriteLine(tal);
                minArray[i] = tal;
            }
            */
        }
    }
}

