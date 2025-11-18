using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Example_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mesaj msj = new Mesaj();
            //msj.metin();

            Kisiler kisi = new Kisiler();

            string ad;
            Console.Write("Isim giriniz:");
            ad = Console.ReadLine();

            kisi.kisiListesi(ad);
            

            Console.Read();
        }
    }
}
