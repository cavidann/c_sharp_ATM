using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] vahidler= new int[5] { 100, 50, 20, 10, 5 };
            Console.Write("Cixarmaq istediyiniz miqdari daxil edin : ");
            int reqem=Convert.ToInt32(Console.ReadLine());
           if (reqem%5!=0)
           {
              Console.WriteLine("imposible: -1\n(Xais olunur sonu 5 ve ya 0 ile biten reqem daxil edin)");
              Console.ReadLine();
           }
           else
            {              
               for (int i = 0; i< vahidler.Length; i++)
                {                  
                if (reqem >= vahidler[i])
                {
                  int qaytarilan_say=reqem / vahidler[i];
                  int novbeti =reqem - vahidler[i] * qaytarilan_say;
                  Console.WriteLine("{0} eded {1}",qaytarilan_say, vahidler[i]);
                  reqem = novbeti;
                }
            }
            Console.ReadLine();                        
            }
        }
    }
}
