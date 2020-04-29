using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CA200420
{
    class Program
    {
        static void Main()
        {

            var pc = new Szamitogep()
            {
                Processor = Processor.Intel_Core_I5,
                Ram = 8,
            };

            pc.GetInfo();

            Console.ReadKey();
        }
    }
}
