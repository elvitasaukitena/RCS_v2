using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    class Uzdevums
    {
        public void Publiska()
        {
            Izvade();
            Console.WriteLine(Saskaitisana());
        }
        private void Izvade()
        {
            Console.WriteLine("Šis ir ");
            Console.WriteLine("Viegls uzdevums");

        }

        private int Saskaitisana()
        {
            int result = 3 + 8;
            return result;

        }

    }

}

