using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hej");
            //Console.WriteLine("Jag heter");
            //Console.WriteLine("TIA");

            //Variabler
            int i = 1;


            int age;
            double weight;
            string name;
            bool IsStudent = true; // or false

            Console.WriteLine("Hi, Welcome to Siri \nWhats your name?");
            name = Console.ReadLine();

            Console.WriteLine("Whats your age?");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Whats your weight?");
            weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Hi my name is " + name + "\n And my age is " + age);
            Console.WriteLine("My weight is " + weight + " kg");
            if(IsStudent)
            {
                Console.WriteLine("And i'm a student at NTI Kronhus");
            }
            else
            {
                Console.WriteLine("När detta blir falskt");
            }
        }
    }
}
