using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Firm

    {
        static void Main()
        {
            Console.Write("Enter the name of firm: ");
            string firmName = Console.ReadLine();

            Console.Write("Enter the address of firm: ");
            string firmAddress = Console.ReadLine();

            Console.Write("Enter the phone number of firm: ");
            string firmNumber = Console.ReadLine();

            Console.Write("Enter the fax of firm: ");
            string firmFax = Console.ReadLine();

            Console.Write("Enter the web site of firm: ");
            string firmSite = Console.ReadLine();

            Console.Write("Enter the first name of firm's manager: ");
            string managerFirstName = Console.ReadLine();

            Console.Write("Enter the last name of firm's manager: ");
            string managerLastName = Console.ReadLine();

            Console.Write("Enter the phone number of manager: ");
            string managerNumber = Console.ReadLine();


            Console.Write("\nFirm Name: {0} \nAddress: {1} \nPhone number: {2} \nFax: {3} \nWeb site: {4} \n", firmName, firmAddress, firmNumber, firmFax, firmSite);
            Console.Write("\nManager: {0} {1} \nPhone number: {2} \n \n", managerFirstName, managerLastName, managerNumber);
            
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