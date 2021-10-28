using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Person David = new Person("David",21,185.4,72.3);
            Person Alice = new Person("Alice",18,125.7,67.1);

            // Initialize David
            David.Age = 21;
            David.Name = "David";
            David.Weight = 185.4;
            David.Height = 72.3;

            // Initialize Alice
            Alice.Age = 18;
            Alice.Name = "Alice";
            Alice.Weight = 125.7;
            Alice.Height = 67.1;

            // print some values 
            Console.WriteLine("David's age = {0}; David's weight = {1}; David's height = {2}", David.Age, David.Weight,David.Height);
            Console.WriteLine("Alice's age = {0}; Alice's weight = {1}; Alice's height = {2}", Alice.Age, Alice.Weight,Alice.Height);*/
            Shape[] shapeArray =
            {
            new Square(5, "Square #1"),
            new Circle(3, "Circle #2"),
            new Rectangle(7,6, "Rectangle #3")
            };

            System.Console.WriteLine("Shapes Collection");
            foreach (Shape s in shapeArray)
            {
                System.Console.WriteLine(s);
                System.Console.WriteLine("Its area = {0}", s.Area);
            }
        }
    }
}
