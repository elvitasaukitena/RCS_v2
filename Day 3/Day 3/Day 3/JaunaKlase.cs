using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    class JaunaKlase
    {
        public int globals = 4;
        private int LokalsKlasei = 3;
        public int Saskaitit(int a, int b)
        {
            int rezultats = a + b;//mainigos var uzrakstīt gan funkcijā, gan klasē. 
            //Teksts();
            globals = 6;
            return rezultats;//vienmer ir pēdējā funkcija, ja kaut kas būs aiz tā, tas neizpildīsies. 
        }

        public void Teksts()
        {
            Console.WriteLine("Debug, Teksts");
            globals = 3;
        }
    }
}

