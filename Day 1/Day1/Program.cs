using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int vesels = 4; //vesels skaitlis
             Console.WriteLine(vesels);
             vesels = 5;
             Console.WriteLine(vesels);

            /* int rezultats = vesels + 4;
             /*vairaku
              * rindiņu 
              * komentārs */

            double komats = 5.6; //skaitlis ar komatu
            char simbols = '7';
            string virkne = "abc";
            virkne = virkne + simbols; //šādi var darīt 
            Console.WriteLine(virkne);*/
            Console.WriteLine("Ludzu ievadiet kaut ko: ");
            string virkne2 = Console.ReadLine();

            int rezultats = Convert.ToInt16(virkne2);
            Console.WriteLine(rezultats);
            rezultats = rezultats + 6;
            Console.WriteLine(rezultats);
            Console.ReadLine(); 

    
            
            /*Console.WriteLine("Kā jūs sauc?");
            string virkne = Console.ReadLine();
            Console.WriteLine("Kāds gads ir šobrīd?");
            string gads = Console.ReadLine(); //var likt vienu 
            Console.WriteLine("Kurā gadā esat dzimis?");
            string gads2 = Console.ReadLine(); //var likt vienu
            int rezultats1 = Convert.ToInt16(gads);
            int rezultats2 = Convert.ToInt16(gads2);
            rezultats2 = rezultats1 - rezultats2;
            Console.WriteLine("Sveiki, " + virkne + "Jums ir " + rezultats2 + "gadi!");
            Console.ReadLine();
          
            
            Console.WriteLine("Hello World!");
            Console.ReadLine();*/
        }
    }
}
