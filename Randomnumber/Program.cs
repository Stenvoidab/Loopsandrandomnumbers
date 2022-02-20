using System;

namespace Randomnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //progremm genereerib juhusliku numbri ühest kümneni
            //kui genereeritud number on 5, programm lõpetab töö ja soovib kasutajale head päeva
            //kui number on midagi muud, programm jätkab tööd

            Random rnd = new Random();
            int i = 0;
            while(i != 5)
            {
                int MyRandomNumber = rnd.Next(1, 11);
                Console.WriteLine($"Juhuslik number on {MyRandomNumber}.");
                if (MyRandomNumber == 5)
                {
                    i = MyRandomNumber;
                }
                Console.WriteLine("Head päeva!");
            }


            

           



        }
    }
}
