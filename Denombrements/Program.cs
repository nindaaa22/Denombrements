using System;
 /**
  * titre: denombrement
  * auteur: LM
  * date creation: 05.12.2021
  */


namespace Denombrements
{
    class Program
    {
        static void Main(string[] args)
        {

            //declaration variable
            int n, t, c = 1;
            
            //affichage du menu

            
            while (c != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                c = int.Parse(Console.ReadLine());

                if (c == 0) { Environment.Exit(0); }

                // Coix de permutation  
                if (c == 1)
                {
                    Console.Write("nombre total d'éléments à gérer = "); 
                    n = int.Parse(Console.ReadLine()); 
                                                           
                    long r = 1;
                    for (int k = 1; k <= n; k++)
                        r *= k;
                    Console.WriteLine(n + "! = " + r);
                }
                // CHoix Arrangement 
                else
                {
                    if (c == 2)
                    {
                        Console.Write("nombre total d'éléments à gérer = "); 
                        t = int.Parse(Console.ReadLine()); 
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        n = int.Parse(Console.ReadLine()); 
                       
                        long r = 1;
                        for (int k = (t - n + 1); k <= t; k++)
                            r *= k;
                        
                        Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                    }
                    // Choix combinaison 
                    else
                    {
                        Console.Write("nombre total d'éléments à gérer = "); 
                        t = int.Parse(Console.ReadLine()); 
                        Console.Write("nombre d'éléments dans le sous ensemble = "); 
                        n = int.Parse(Console.ReadLine()); 
                        
                        long r1 = 1;
                        for (int k = (t - n + 1); k <= t; k++)
                            r1 *= k;
                        
                        long r2 = 1;
                        for (int k = 1; k <= n; k++)
                            r2 *= k;
                        
                        Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
