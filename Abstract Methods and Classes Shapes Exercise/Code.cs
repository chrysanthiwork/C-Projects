using System;

namespace Coding.Exercise
{
    public static class ExerciseShapes
    {
        public static List<double> GetShapesAreas(List<Shape> shapes)
        {
            var result = new List<double>();

            foreach (var shape in shapes)
            {
                result.Add(shape.CalculateArea());
            }

            return result;
        }
    }

    public abstract class Shape
    {
        public abstract double CalculateArea();
    }

    public class Square : Shape
    {
        public double Side { get; }

        public Square(double side)
        {
            Side = side;
        }

        public override double CalculateArea() => Side * Side;
    }


    public class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea() => Height * Width;
    }

    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea() => Math.PI * Math.Pow(Radius, 2);
    }
}































//using Pizzeria;
//using System.Text.Json;

//var person = new Person
//{
//    FirstName = "John",
//    LastName = "Smith",
//    YearOfBirth = 1972
//};

//var asJson = JsonSerializer.Serialize(person);
//Console.WriteLine("As JSON:");
//Console.WriteLine(asJson);

//var personJson = 
//    "{\"FirstName\":\"John\",\"LastName\":\"Smith\",\"YearOfBirth\":1972}";

//var personFromJson = JsonSerializer.Deserialize<Person>(personJson);

//Console.ReadKey();

//public class Person
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public int YearOfBirth { get; set; }
//}

