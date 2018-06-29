using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class pd1_1
    {
        public void Izsaukt()
        {
            Vards();
        }
        public void Izsaukt2()
        {
            Simboli();
        }
        public void Izsaukt3()
        {
            Console.WriteLine(AtgrieztSkaitli());
        }
        private void Vards()
        {
            Console.WriteLine("Lūdzu, ievadiet savu vārdu.");
            string vards = Console.ReadLine();
            Console.WriteLine("Jūs sauc " + vards);
        }
        private void Simboli()
        {
            Console.WriteLine("Lūdzu, ievadiet kaut ko.");
            string kautkas = Console.ReadLine();
            Console.WriteLine("Lūdzu, ievadiet kādu skaitli.");
            string skaitlis = Console.ReadLine();
            Console.WriteLine("Jūs ievadījāt " + kautkas + " un šādu skaitli " + skaitlis);
        }
        private int AtgrieztSkaitli()
        {
            Console.WriteLine("Lūdzu, ievadiet skaitli.");
            string skaitlis = Console.ReadLine();
            int parverst = Convert.ToInt16(skaitlis);
            return parverst; 
        }
    }
}
