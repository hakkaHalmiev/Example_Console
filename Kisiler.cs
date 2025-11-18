using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Console
{
    internal class Kisiler
    {
        public void kisiListesi()
        {
            for(int i = 1; i<10; i++)
            {
                Console.WriteLine($"{i}.Kisi");
            }
        }
    }
}
