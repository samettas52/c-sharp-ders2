using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            double piyasaBugun = 115000.23;
            double piyasaDun = 116000;
            string mesajArtis = "Artış oku";
            string mesajDüşüş = "Düşüş oku";
            string mesajSabit = "Sabit oku";
            //EĞER TRUE FALSE İLE ÇÖZEBİLCEĞİMZ BİR KODSA
            //bool sonuc= piyasaBugun < piyasaDun;
            //if (sonuc == true)
            //{
            //    Console.WriteLine(mesajArtis);
            //}
            //else 
            //{
            //    Console.WriteLine(mesajDüşüş);
            //}

            //EĞER TRUE FASLE DEĞERLERİNDEN FAZLA BİR DEĞER VARSA
            if (piyasaBugun > piyasaDun)
            {
                Console.WriteLine(mesajArtis);
            }
            else if (piyasaBugun == piyasaDun)
            {
                Console.WriteLine(mesajSabit);
            }
            else
            {
                Console.WriteLine(mesajDüşüş);
            }
            Console.Read();
        }
    }
}
