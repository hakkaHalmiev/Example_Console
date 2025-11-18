using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mesaj msj = new Mesaj();
            //msj.metin();

            Kisiler kisi = new Kisiler();
            kisi.kisiListesi("Hakki");
            

            Console.Read();
        }
    }
}
