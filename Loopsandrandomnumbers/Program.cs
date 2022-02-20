using System;

namespace Loopsandrandomnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada PIn koodi
            //Programm võrdleb sisestatud koodi arvuga 1234
            //Kui sisestadud kood on 1234, konsool kuvab "tere tulemast"
            //kui sisestatud kood on midagi muud, konsool kuvab "vale PIN,proovi uuesti."
            //kasutajal on 3 katset

            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Sisestage oma PIN kood.");
                int UserPIN = Convert.ToInt32(Console.ReadLine());
                
                if (UserPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i = i++;
                    Console.WriteLine($"Vale PIN, proovi uuesti.{3 - i} katset jäänud.");
                }
                Console.WriteLine("Head päeva!");

            }
            
            
            
           
        }
    }
}
