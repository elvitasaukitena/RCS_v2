using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class Program
    {
        static void Main(string[] args)//void izmanto, ja vajag kaut ko tikai izvadīt. 
        {
            pd1_1 pirmais = new pd1_1();
            pirmais.Izsaukt();
            pirmais.Izsaukt2();
            pirmais.Izsaukt3();
            Console.WriteLine("Kuru no programmām Jūs vēlaties izsaukt - 1, 2 vai 3?");
            string atbilde = Console.ReadLine();
            if (atbilde == "1")
            {
                pirmais.Izsaukt();
            }
            else
            { if (atbilde == "2")
                {
                    pirmais.Izsaukt2();
                }
                if (atbilde == "3")
                {
                    pirmais.Izsaukt3();
                }
                else 
                {
                    Console.WriteLine("Kļūdaina ievade!");
                }
            }
            pd1_2 otrais = new pd1_2();
            otrais.Uzd1();
            otrais.Uzd2();
            otrais.Tresais();
            otrais.Ceturtais();
            otrais.Izsauca();
            Console.WriteLine("Kurai no klasēm jūs vēlaties piekļūt pd1_1 vai pd1_2?");
            string atbildu = Console.ReadLine();
            switch (atbildu)
            {
                case "pd1_1":
                    pirmais.Izsaukt();
                    pirmais.Izsaukt2();
                    pirmais.Izsaukt3();
                    break;
                case "pd1_2":
                    otrais.Uzd1();
                    otrais.Uzd2();
                    otrais.Tresais();
                    otrais.Ceturtais();
                    otrais.Izsauca();
                    break;
                default:
                    Console.WriteLine("Nepareiza ievade!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
