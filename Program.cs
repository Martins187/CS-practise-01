using System;
using System.Linq;

namespace _2nd_pasa_projekts
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Pirmais lietotājs ievada vārdu AR MAZAJIEM BURTIEM, otrs spēlētājs neskatās!");
            string name = Console.ReadLine();
            Console.Clear();
            
            
            Console.WriteLine("Tagad iedod klēpjdatoru otram cilvēkam," + "\n" +
                "lai viņš varētu minēt tavu vārdu!");
            
            int skaits1 = name.Length;
            char[] burtu_kopa = name.ToCharArray();
            
            
            Console.WriteLine("\n");

            for (int i = 1; i <= skaits1; i++)
            {
                Console.Write("__ ");
            }
            Console.Write("( " + skaits1 + " )");
            Console.WriteLine("\n");
            Console.WriteLine("\n" + "Ok. sāc minēt PA VIENAM BURTAM, vai arī raksti pilnu vārdu, ja esi pārliecināts, tev ir 5 dzīvības!");
            int a = 5;
            string answer = ("");
            string abc = "1";
            char tuksa_vieta = Convert.ToChar(abc);
            char[] atbilzu_kopa = new char[skaits1];
            for (int g = 0; g<skaits1; g++)
            {
                atbilzu_kopa[g] = tuksa_vieta;
            }

            while (a >= 0)
            {
                answer = Console.ReadLine();
                int skaits2 = answer.Length;
                if ( skaits2 == 1)
                {
                    char burts = Convert.ToChar(answer);
                    
                    if (name.Contains(burts))
                    {
                        for (int j = 0; j < skaits1; j++)
                        {
                            if (burtu_kopa[j] == burts)
                            {
                                atbilzu_kopa[j] = burts;
                            }

                        }

                        if (atbilzu_kopa.Contains(tuksa_vieta))
                        {
                            Console.Clear();
                            Console.WriteLine("Malacis, trāpiji, turpini minēt!" + "\n");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Apsveicu, uzminēji!");
                        }


                       
                        foreach (char burts2 in atbilzu_kopa)
                        {
                            
                            if (burts2 == tuksa_vieta)
                            {
                                Console.Write(" _ ");
                            }
                            else
                            {
                                Console.Write(" " + burts2 + " ");
                            }
                        }
                        
                    }
                    else
                    {
                        a -= 1;
                        Console.WriteLine("Aj, netrāpiji, atlikušas " + (a) + " dzīvības!" + "\n");
                        foreach (char burts2 in atbilzu_kopa)
                        {

                            if (burts2 == tuksa_vieta)
                            {
                                Console.Write(" _ ");
                            }
                            else
                            {
                                Console.Write(burts2 + " ");
                            }
                        }
                        
                    }

                    Console.WriteLine("\n");
                }
                else if (name == answer)
                {
                    Console.WriteLine("Apsveicu, uzminēji!");
                    return;
                }
                else
                {
                    a -= 1;
                    Console.WriteLine("Aj, netrāpiji, atlikušas " + (a) + " dzīvības!");
                    
                }
            }
            Console.WriteLine("Aj, zaudēji!");

        }
        
    }
}
