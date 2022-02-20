using System;

namespace PINinfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada PIn koodi
            //Programm võrdleb sisestatud koodi arvuga 1234
            //Kui sisestadud kood on 1234, konsool kuvab "tere tulemast"
            //kui sisestatud kood on midagi muud, konsool kuvab "vale PIN,proovi uuesti."
            //katsete arv on piiramatu

            bool loopactive = true;
            int i = 0;
            while (loopactive)
            {
                Console.WriteLine("Sisestage oma PIN.");
                int UserPIN = Convert.ToInt32(Console.ReadLine());
                if (UserPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    loopactive = false;
                }
                else
                {
                    i++;
                    Console.WriteLine("Vale PIN, proovi uuesti.");
                    Console.WriteLine($"{i}. katse.");
                }
            }
            Console.WriteLine("Head päeva!");
        }
    }
}
