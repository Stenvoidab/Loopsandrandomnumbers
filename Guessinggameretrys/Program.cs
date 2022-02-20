using System;

namespace Guessinggameretrys
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri ühest kümneni
            //Kasutaja peab selle numbri ära arvama
            //kui kasutaja suutis numbri ära arvata, siis on kasutaja mängu võitnud
            //kasutajal on 3 katset, kui ei arva ära, võidab mängu arvuti.
            //programm genereerib juhusliku numbrit vaid ühe korra

            Random rnd = new Random();
            int CPUnumber = rnd.Next(1, 11);
            
            int i = 0;

            while (i < 3)
               
            {
               Console.WriteLine("Arva ära number ühest kümneni.");
                int UserGuess = Convert.ToInt32(Console.ReadLine());

                if (UserGuess == CPUnumber)
                {
                    Console.WriteLine("Õige! Võitsid! Head päeva.");
                    break;
                }
                if (i == 1)
                {
                    i++;
                    Console.WriteLine("Proovi uuesti!, viimane katse.");
                }
               

                else
                {
                    i++;
                    Console.WriteLine("proovi uuesti!");
                }
               
            }
        }
    }
}
