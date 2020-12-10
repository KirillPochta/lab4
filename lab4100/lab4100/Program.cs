using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4100
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "при5ет";
            
           
            Set  A = new Set(new int[] { 1, 2, 3,-2 , 5});
            Set  B = new Set(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
            var C = A > 3;
            Console.WriteLine(C);
            var G = A < B;
            Console.WriteLine(G);
            Set H = A * B;
            for(int i = 0;i<H.mnojestvo.Length;i++)
            {
                Console.WriteLine(H.mnojestvo[i]);
            }


            Owner Kirill = new Owner(7, "Кирилл", "ByTech");
            Date data = new Date(27,02,2002);
            str.first_number_in_string();
            Console.WriteLine("-------------");
            StaticOperation.Sum(A);
            StaticOperation.RAznost(A);
            StaticOperation.Dalete_plus_number(A);
            
           
            A.Dalete_plus_number();
            Kirill.GetInfo();
        }
    }

    

}
