using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA200420
{
    class Program
    {
        static void Main()
        {
            var pc = new Szamitogep();

            //pc.Processor = null; ===> nem jó!
            //pc.Processor = "Texas Holdem TST2";  ===> nem jó!

            pc.Processor = "krumpli"; //===>jó!
            Console.WriteLine($"A PC-nek a processora: {pc.Processor}");


            Console.ReadKey();
        }
    }
}
