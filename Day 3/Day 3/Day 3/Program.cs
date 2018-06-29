using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string vards, uzvards; //deklaret var ari sadi. 
            Console.WriteLine("Lūdzu ievadiet savu vārdu!");
            vards = Console.ReadLine();
            Console.WriteLine("Lūdzu, ievadiet savu uzvardu!");
            uzvards = Console.ReadLine();
            RinkaDiametrs();
            //IzvaditSveicienu(vards, uzvards);*/
            /*JaunaKlase objekts1 = new JaunaKlase();
            JaunaKlase objekts2 = new JaunaKlase();

            int vertiba = objekts1.Saskaitit(8,5);//neizvadījās, jo pēc tam ir piesķirta jauna vērtība
            objekts1.globals = 5 + 5;
            Console.WriteLine(objekts1.globals);
            Console.WriteLine(objekts2.globals);//ja izmaina vertibu globals objekts1, tad objekts2 nemainās.
            Matematika objekts = new Matematika();
            int saskaitisana = objekts.Saskaita();
            Console.WriteLine(saskaitisana);
            int atnemsana = objekts.Atnem();
            Console.WriteLine(atnemsana);
            Riņķis objekts1 = new Riņķis();
            objekts1.Rinkis();
            Console.WriteLine(objekts1);*/
            IzvadaSkaitli(); 
            Console.ReadLine();
        }

        static void IzvaditSveicienu(string a, string b) //var tā darīt ar visiem veidiem. 
        {
            /*Console.WriteLine("Sveiki " + a + " " + b + " prieks tevi redzēt!");
        }

        static void RinkaDiametrs()
        {
            string radiuss;
            double diametrs, linijasgarums; 
            Console.WriteLine("Lūdzu, ievadiet riņķa rādiusu!");
            radiuss = Console.ReadLine();
            double radiuss2 = Convert.ToInt16(radiuss); 
            diametrs = 2 * radiuss2;
            linijasgarums = 2 * 3.14 * radiuss2;
            Console.WriteLine("Diametrs ir " + diametrs + " Riņķa līnijas garums ir " + linijasgarums + " Pi = 3,14");*/
            
        }
        static void IzvadaSkaitli()
        {
            string skaitlis;
            skaitlis = Console.ReadLine();      
            Console.WriteLine("Mans skaitlis ir " + skaitlis);
        }
        static void Degviela()
        {
            

        }




    }
}
