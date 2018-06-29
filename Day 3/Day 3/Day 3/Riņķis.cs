using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    class Riņķis
    {
        public void Rinkis()
        {
            string radiuss;
            double radiuss1, linija; 
            Console.WriteLine("Lūdzu, ievadiet riņķa rādiusu!");
            radiuss = Console.ReadLine();
            double radiuss2 = Convert.ToInt16(radiuss);
            radiuss1 = 2 * radiuss2 * 3.14;
            linija = 3.14 * radiuss2 * radiuss2;
            Console.WriteLine("Radiuss ir " + radiuss1 + " riņķa līnijas garums ir " + linija);
        }
    }
}
