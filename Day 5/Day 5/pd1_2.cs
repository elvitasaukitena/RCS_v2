using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class pd1_2
    {
        public void Uzd1()
        {
            Darbibas();
        }
        private void Darbibas()
        {
            Console.WriteLine("Lūdzu ievadiet kādu skaitli ar komatiem.");
            string skaitlis1 = Console.ReadLine();
            double A1 = Convert.ToDouble(skaitlis1);
            Console.WriteLine("Lūdzu ievadiet vēlvienu skaitli ar komatiem.");
            string skaitlis2 = Console.ReadLine();
            double A2 = Convert.ToDouble(skaitlis2);
            Console.WriteLine("Kādas darbības jūs vēlaties izpildīt? Ierakstat: +, -, * vai /.");
            string atbilde = Console.ReadLine();


            switch (atbilde)
            {
                case "+":
                    A2 = A1 + A2;
                    break;
                case "-":
                    A1 = A1 - A2;
                    break;
                case "*":
                    A1 = A1 * A2;
                    break;
                case "/":
                    A1 = A1 / A2;
                    break;
                default:
                    Console.WriteLine("Nepareiza ievade!");
                    break;

            }

        }
        public void Uzd2()
        {
            LetterGrade();
        }
        private void LetterGrade()
        {
            Console.WriteLine("Lūdzu ievadiet kādu no variantiem - 4.5, 4, 3.5, 3, 2.5, 2, 1, 0");
            string atbilde = Console.ReadLine();
            switch (atbilde)
            {
                case "4.5":
                    Console.WriteLine("A+");
                    break;
                case "4":
                    Console.WriteLine("A");
                    break;
                case "3.5":
                    Console.WriteLine("B+");
                    break;
                case "3":
                    Console.WriteLine("B");
                    break;
                case "2.5":
                    Console.WriteLine("C+");
                    break;
                case "2":
                    Console.WriteLine("C");
                    break;
                case "1":
                    Console.WriteLine("D");
                    break;
                case "0":
                    Console.WriteLine("F");
                    break;
                default:
                    Console.WriteLine("Nepareiza ievade!");
                    break;

            }

        }
        public void Tresais()
        {
            Kapinasana();
        }
        private int Kapinasana()
        {
            Console.WriteLine("Lūdzu ievadiet skaitli!");
            string atbilde = Console.ReadLine();
            int atbilde1 = Convert.ToInt16(atbilde);
            Console.WriteLine("Jus vēlaties kāpināt 2 vai 3 pakāpē?");
            string Atbilde2 = Console.ReadLine();
            int atbilde3 = Convert.ToInt16(Atbilde2);
            switch (Atbilde2)
            {
                case "2":
                    atbilde3 = atbilde1 * atbilde1;
                    break;
                case "3":
                    atbilde3 = atbilde1 * atbilde1 * atbilde1;
                    break;
                default:
                    Console.WriteLine("Neapreiza ievade!");
                    break;

            }
            return atbilde3;

        }
        public void Ceturtais()
        {
            Lielakais();
        }
        private int Lielakais()
        {
            Console.WriteLine("Lūdzu ievadiet kādu skaitli.");
            string skaitlis1 = Console.ReadLine();
            int A1 = Convert.ToInt16(skaitlis1);
            Console.WriteLine("Lūdzu ievadiet vēlvienu skaitli.");
            string skaitlis2 = Console.ReadLine();
            int A2 = Convert.ToInt16(skaitlis2);
            if (A2 > A1)
            {
                Console.WriteLine("Lielākais skaitlis ir " + A2);
            }
            else
            {if (A2 < A1)
                {
                    Console.WriteLine("Lielākais skaitlis ir " + A1);
                }
                else
                {
                    Console.WriteLine("Kļūdaina ievade!");
                }
            }
            return A2;


        }
        public void Izsauca()
        {
            Funkcija();
        }
        private void Funkcija()
        {
            Console.WriteLine("Kuru no funkcijām Jūs vēlaties izsaukt? Ierakstiet skaitli no 1-7.");
            string atbilde = Console.ReadLine();

            switch (atbilde)
            {
                case "1":
                    pd1_1 pirmais = new pd1_1();
                    pirmais.Izsaukt();
                    break;
                case "2":
                    pd1_1 otrais = new pd1_1();
                    otrais.Izsaukt2();
                    break;
                case "3":
                    pd1_1 tresais = new pd1_1();
                    tresais.Izsaukt3();
                    break;
                case "4":
                    pd1_2 ceturtais = new pd1_2();
                    ceturtais.Uzd1();
                    break;
                case "5":
                    pd1_2 piektais = new pd1_2();
                    piektais.Uzd2();
                    break;
                case "6":
                    pd1_2 sestais = new pd1_2();
                    sestais.Tresais();
                    break;
                case "7":
                    pd1_2 septitais = new pd1_2();
                    septitais.Ceturtais();
                    break;
                default:
                    Console.WriteLine("Kļūdaina ievade!");
                    break;

            }
        }
    }

}
