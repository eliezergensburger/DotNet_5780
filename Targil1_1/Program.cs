using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil1_1
{
    class Program
    {
        static Random r = new Random(DateTime.Now.Millisecond);
        const int SIZE = 20;
        static void Main(string[] args)
        {
            int[] A = new int[SIZE];
            int[] B = new int[SIZE];
            int[]C = new int[SIZE];
            //init the arrays to random values
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = r.Next(18, 122);
                B[i] = r.Next(18, 122);
                C[i] = Math.Abs(A[i] - B[i]);
            }
            foreach (int item in A)
            {
                Console.Write("{0,3} ",item);
            }
            Console.WriteLine();
            foreach (int item in B)
            {
                Console.Write("{0,3} ", item);
            }
            Console.WriteLine();
            foreach (int item in C)
            {
                Console.Write("{0,3} ", item);
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
