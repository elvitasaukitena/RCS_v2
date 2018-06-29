using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Uzdevums nosaukums = new Uzdevums();
            Zarosanas zari = new Zarosanas();
            Console.WriteLine("Kuru programmu jūs vēlaties palaist - 1 vai 2?");
            string atbilde = Console.ReadLine();
            nosaukums.Publiska();
            zari.LielaksVaiMazaks();

            if (atbilde == "1")
            {
                nosaukums.Publiska();
            }
            else
            {
                if (atbilde == "2")
                {
                    zari.LielaksVaiMazaks();
                }
                else
                {
                    Console.WriteLine("Nav pareiza ievade!");
                }
                //vai ir <5  >5
            }

            switch (atbilde)
            {
                case "1": // ja in raksta bez pēdiņām. 
                    nosaukums.Publiska();
                    break;
                case "2":
                    zari.LielaksVaiMazaks();
                    break;
                default:
                    Console.WriteLine("Nepareiza ievade.");
                    break;} */
            

            Zarosanas Pirma = new Zarosanas();
            Pirma.ArIf();
            //Pirma.ArCase();
            Console.ReadLine();

        }
    }
}
