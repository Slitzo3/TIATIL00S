using System;

namespace IfElseAndLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Skrin in ditt namn"); //skriv in ditt namn
            //string namn = Console.ReadLine();


            //Console.WriteLine("Här tar jag slut");

            double lektiontid = 15.00d;
            double lararenAnkomst;
            Console.WriteLine("När kom läraren?");
            lararenAnkomst = double.Parse(Console.ReadLine());

            if(lararenAnkomst > (lektiontid + 0.15d))
            { 
                Console.WriteLine("Då får du gå");
            }
            else
            {
                Console.WriteLine("Yes vi har lektion");
            }


        }
    }
}
