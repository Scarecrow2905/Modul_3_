using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    static class Classes
    {
        static void Main(string[] args)
        {
            // class = A bundle of related code.
            //      Can be used as a "blueprint" to create objects (OOP) Object-Oriented-Programming

            //Math.Round(3.14);
            //Math.Abs(-3.14);
            //Math.Pow(2, 3);

            Messages.Hello(); //These will run from the Messages.cs 
            Messages.Waiting();
            Messages.Bye();

            Console.ReadKey();
        }
    }
}
