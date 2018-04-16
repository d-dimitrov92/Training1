using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdBit
{
    class pravougulnik

    {
        static void Main()
        {
            Console.Write("Number: ");

            
            for (int i = int.Parse(Console.ReadLine()); 1 < i && i < 100; i++)
            {
                if(i % i == 0)
                {
                    Console.WriteLine(i);
                }

                if(i%i != 0)
                {
                    Console.WriteLine("error");
                }
            } 
            
        }
    }
}










//Console.Write("Enter numer in formar abcd: ");
//int abcd = int.Parse(Console.ReadLine());

//int d = abcd % 10;
//int c = (abcd / 10) % 10;
//int b = (abcd / 100) % 10;
//int a = (abcd / 1000) % 10;
//Console.WriteLine("Sbor ---> " +(a+b+c+d));
//Console.WriteLine("Obraten red ---> " + d + c + b + a);
//Console.WriteLine("stranna rabota ---> " + d + a + b + c);
//Console.WriteLine("Stranna rabota2 ---> " + a + c + b + d);







//Console.Write("n = ");
//            int n = int.Parse(Console.ReadLine());
//Console.Write("p = ");
//            int p = int.Parse(Console.ReadLine());
//Console.Write("v (0 or 1) = ");
//            int v = int.Parse(Console.ReadLine());

//            if (v == 0)
//            {
//                n = n & (~(1 << p));
//                Console.WriteLine(n);
//            }

//            if (v == 1)
//            {
//                n = n | (1 << p);
//                Console.WriteLine(n);
//            }