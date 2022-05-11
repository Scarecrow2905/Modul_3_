using System;

namespace objects
{
    class Program
    {
        static void Main(string[] args)
        {
            // object = An instance of a class
            //          A class can be used as a blueprint to create objects (OOP) Object Oriented Programming
            //          objects can have fields and methods (characteristics and actions)

            Human human1 = new Human(); // Here, human1 and human2 is given the Human Class. As they are now a "new Human();"
            Human human2 = new Human(); 

            human1.name = "Rick";
            human1.age = 65;

            human2.name = "Morty";
            human2.age = 16;

            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();

            Console.ReadKey();
        }
    }
    class Human // Here we will "explain" what the class Human is.
    {
        public String name; // Fields. Defining characteristics
        public int age;

        public void Eat() // Methods
        {
            Console.WriteLine(name + " is eating");
        }
        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }
}