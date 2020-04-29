using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA200420
{
    enum Processor
    {
        Intel_Core_I5,
        Intel_Core_I7,
        Intel_Core_I9,
        AMD_Ryren_5,
        AMD_Ryzen_7,
    }

    class Szamitogep
    {
        public Processor Processor { get; set; }

        private int _ram;
        public int Ram
        {
            get
            {
                return _ram;
            }
            set
            {
                if (value <= 0) throw new Exception("nem lehet ennyi ran a gépbben");
                _ram = value;
            }
        }

        public void GetInfo()
        {
            Console.WriteLine(
                "Processor: {0}\n" +
                "RAM:       {1} GB",
                this.Processor, this.Ram);
        }


    }
}
