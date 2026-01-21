using System;

namespace Learning
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Car: {Brand} {Model}, Year: {Year}");
        }
    }

    public enum Color
    {
        Red,
        Green,
        Blue,
        Yellow,
        Black,
        White
    }

    private enum Size
    {
        Small,
        Medium,
        Large,
        ExtraLarge
    }

    public class Animal
    {
        public string Species { get; set; }
        public int Legs { get; set; }

        public Animal(string species, int legs)
        {
            Species = species;
            Legs = legs;
        }

        public void Speak()
        {
            Console.WriteLine($"The {Species} makes a sound.");
        }
    }

    public class Program
    {
        private void MoveCapsule()
        {
            
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine("Hello " + message);
        }
    }
}
    public string Model { get; set; }
        public int Year { get; set; }

        

       