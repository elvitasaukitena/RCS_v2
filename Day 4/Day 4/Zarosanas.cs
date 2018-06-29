using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    class Zarosanas
    {
        public void LielaksVaiMazaks()
        {
            Console.WriteLine("Lūdzu, ievadiet skaitli: ");
            string input = Console.ReadLine();
            int skaiitlis = Convert.ToInt16(input);

            //vai skaitlis ir lielaks vai mazaks par 5 
            /*
             * <
             * >
             * <=
             * >=
             * ==
             * !=
             * */


            if (skaiitlis > 5)
            {
                Console.WriteLine("Skaitlis " + skaiitlis + " ir lielaks par pieci");//zem if izpildās viena rinda ja nav iekavas. 
            }
            if (skaiitlis ==5)
            {
                Console.WriteLine("Skaitlis " + skaiitlis + " ir vienads");
            }
            else
            {
                if (skaiitlis == 5)
                {
                    Console.WriteLine("Skaitlis " + skaiitlis + " ir vienads");
                }
                else
                {
                    Console.WriteLine("Skaitlis " + skaiitlis + " ir mazāks par pieci");
                }


            }
        }
        public void ArIf()//ievade no 0-10 - 10 -"ievade ir desmit" 11 vai mazak par 0 - kludaina ievade
        {
            Console.WriteLine("Lūdzu ivadiet skaitli no 0-10.");
            string ievade = Console.ReadLine();
            int gatavs = Convert.ToInt16(ievade);

            if (gatavs > 10 )
            if (gatavs == 0)
            {
                Console.WriteLine("Ievade ir nulle. ");
                if (gatavs == 1)
                {
                    Console.WriteLine("Ievade ir viens. ");

                    if (gatavs == 2)
                    {
                        Console.WriteLine("Ievade ir divi. ");

                        if (gatavs == 3)
                        {
                            Console.WriteLine("Ievade ir trīs. ");

                            if (gatavs == 4)
                            {
                                Console.WriteLine("Ievade ir četri. ");

                                if (gatavs == 5)
                                {
                                    Console.WriteLine("Ievade ir pieci. ");

                                    if (gatavs == 6)
                                    {
                                        Console.WriteLine("Ievade ir seši. ");

                                        if (gatavs == 7)
                                        {
                                            Console.WriteLine("Ievade ir septiņi. ");

                                            if (gatavs == 8)
                                            {
                                                Console.WriteLine("Ievade ir astoņi. ");

                                                if (gatavs == 9)
                                                {
                                                    Console.WriteLine("Ievade ir deviņi. ");

                                                    if (gatavs == 10)
                                                    {
                                                        Console.WriteLine("Ievade ir desmit. ");
                                                    }

                                                    else
                                                    {

                                                        Console.WriteLine("Kļūdaina ievade!");
                                                    }









                                                    
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }
                }
            }
        }


        public void ArCase(string ievade)
        {
            
            switch (ievade)
            {
                case "0":
                    Console.WriteLine("Ievade ir nulle.");
                    break;
                case "1":
                    Console.WriteLine("Ievade ir viens.");
                    break;
                case "2":
                    Console.WriteLine("Ievade ir divi.");
                    break;
                case "3":
                    Console.WriteLine("Ievade ir trīs.");
                    break;
                case "4":
                    Console.WriteLine("Ievade ir četri.");
                    break;
                case "5":
                    Console.WriteLine("Ievade ir pieci.");
                    break;
                case "6":
                    Console.WriteLine("Ievade ir seši.");
                    break;
                case "7":
                    Console.WriteLine("Ievade ir septiņi.");
                    break;
                case "8":
                    Console.WriteLine("Ievade ir astoņi.");
                    break;
                case "9":
                    Console.WriteLine("Ievade ir deviņi.");
                    break;
                case "10":
                    Console.WriteLine("Ievade ir desmit.");
                    break;
                default:
                    Console.WriteLine("Kļūdaina ievade!");
                    break;


            }

        }

    }

}
