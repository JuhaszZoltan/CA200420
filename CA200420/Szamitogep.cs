using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA200420
{
    class Szamitogep
    {
        private static readonly List<string> _processorLista = new List<string>()
        {
            "Intel Core i5",
            "Intel Core i7",
            "Intel Core i9",
            "AMD Ryzen 5",
            "AMD Ryzen 7",
        };


        private string _processor;
        public string Processor
        {
            set
            {
                if (value is null)
                {
                    throw new Exception("a számítógép nem működik processzor nélkül!");
                }

                if (!_processorLista.Contains(value))
                {
                    throw new Exception("ilyen processor nincs az adatbázisban!");
                }

                _processor = value;
            }
            get { return _processor; }
        }


        //gpu
            //GTX 2060
            //AMD RX570 
        //ram
            //4 gb
            //8 gb
            //16 gb
        //drive
            //tipus - hdd / ssd
            //500Gb, 1T, 2T - 128 - 256 - 512           
        //Motherbord (+cs)
            //Z390
            //A320
            //X570
    }
}
