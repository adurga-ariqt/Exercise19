using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Exercise19
{
    internal class triplesum
    {
        static void Main(string[] args)
        {
            SumTriple();
            
           
        }
        public static void SumTriple()
        {
            int a, b ;
            Console.WriteLine("Entervalues:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("entervalues:");
            //a = Convert.ToInt32(Console.ReadLine());
            //b = Convert.ToInt32(Console.ReadLine());


            //return a == b ? (a + b) * 3 : a + b;

            if (a == b)
            {
               // (a + b) * 3;
                Console.WriteLine((a + b)*3);
            }
            else
            {
               // (a + b);
                Console.WriteLine(a + b);
            }
        }


    }
}
