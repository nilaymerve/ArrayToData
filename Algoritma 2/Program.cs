using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Algorithm of the function that returns the data in the names array as a single string data by inserting "-" between them

            string[] isimler = { "nilay", "merve", "ahmet", "ayşe" };
           
            Console.WriteLine(isimleriBirlestir(isimler));
            Console.WriteLine(isimleriBirlestirHoca(isimler));
            Console.ReadKey();
          
        }

        static string isimleriBirlestir(string[] isimler)
        {
            string sonuc = "";
            for(int i=0; i< isimler.Length; i++)
            {
                if (i == isimler.Length - 1)
                    sonuc += isimler[i];
                else
                    sonuc += isimler[i] + "-";
            }
            return sonuc;
        }

       
        static string isimleriBirlestirHoca(string[] isimler)
        {
            string sonuc = "";
            for (int i = 0; i < isimler.Length; i++)
            {
                if (i == 0)
                    sonuc = isimler[i];
                else
                    sonuc += "-"+ isimler[i] ;
            }
            return sonuc;
        }
    }
}
            