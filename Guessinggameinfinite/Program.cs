using System;

namespace Guessinggameinfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri ühest kümneni
            //Kasutaja peab selle numbri ära arvama
            //kui kasutaja suutis numbri ära arvata, siis on kasutaja mängu võitnud
            //katsete arv on piiramatu
            //programm genereerib juhusliku numbrit vaid ühe korra

            Random rnd = new Random();
            int CPUnumber = rnd.Next(1, 11);
            bool loopactive = true;
            int i = 0;

                while (loopactive)
            {
                Console.WriteLine("Arva ära number ühest kümneni.");
                int UserGuess = Convert.ToInt32(Console.ReadLine());

                if (UserGuess == CPUnumber)
                {
                    Console.WriteLine("Õige! Võitsid! Head päeva.");
                    loopactive = false;
                }
                else
                {
                    Console.WriteLine("Proovi uuesti!");
                }
               

            }
        }
    }
}
