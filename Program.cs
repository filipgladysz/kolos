using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolos
{
    class Program
    {

       public static int PairsOfCars(List<int> A)
        {
            int pairs = 0;
           
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (A[i] != A[j]) pairs++;
                }
            }
            return pairs / 2;
        }
        static void Main(string[] args)
        {
            List<int> A = new List<int> { 0, 1, 0, 1, 1};

            int b = PairsOfCars(A);
            Console.WriteLine("{0}",b);
            
            Console.ReadKey();
        }

        
    }
}
