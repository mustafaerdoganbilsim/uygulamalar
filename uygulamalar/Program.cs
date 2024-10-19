using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulamalar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int islem(int sayi1, int sayi2) { 
            
            
                int sonuc=sayi1 + sayi2;
                return sonuc;
            }

            
            Console.WriteLine(islem(3,4));

            Console.Read();
        }
    }
}
