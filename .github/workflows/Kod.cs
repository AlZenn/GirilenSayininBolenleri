using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiBoleniBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
  
  
            Console.WriteLine("Sayı giriniz: ");
               int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hangi bölene kadar bulmak istersiniz yazınız:");
              int bolen = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < bolen; i++)
            {
                if (sayi % i == 0)
                {
                    Console.WriteLine("sayi "+i+" sayisina bölünebilir.");
                }
            }
            
            Console.ReadKey();
         }
    }
}
