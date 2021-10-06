using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            int sumP = 0;
            int sumN = 0;

            int N;
            do
            {
                
                N = Convert.ToInt32(Console.ReadLine());
                if (N > 0)
                {
                    sumP = ++sumP;
                }
                if (N < 0)
                {
                    sumN = ++sumN;
                }
                              

            } while (N != 0);

            if (sumP > sumN)
            {
                Console.WriteLine("Больше положительных чисел.");
            }
            if (sumP < sumN)
            {
                Console.WriteLine("Больше отрицательных чисел.");
            }

            if (sumP == sumN)
            {
                Console.WriteLine("Количество положительных и отрицательных чисел равно");
            }


            Console.ReadKey();
        }
    }
}
