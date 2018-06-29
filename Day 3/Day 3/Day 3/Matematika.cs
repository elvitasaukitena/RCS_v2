using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    class Matematika
    {
        public int Saskaita()
        {
            string skaitlis = Console.ReadLine();
            int rezultats = Convert.ToInt16(skaitlis);
            string skaitlis2 = Console.ReadLine();
            int rezultats2 = Convert.ToInt16(skaitlis2);
            rezultats2 = rezultats + rezultats2;
            return rezultats2;
        }

        public int Atnem()
        {
            string skaitlis = Console.ReadLine();
            int rezultats = Convert.ToInt16(skaitlis);
            string skaitlis2 = Console.ReadLine();
            int rezultats2 = Convert.ToInt16(skaitlis2);
            rezultats2 = rezultats - rezultats2;
            return rezultats2;
        }

   
        
    }
}
