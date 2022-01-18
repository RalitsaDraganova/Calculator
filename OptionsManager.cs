using System;

namespace GitExercise
{
    public static class OptionsManager
    {
        public static string[] OptionsList = {
            "a - Add"
        };

        public static void Add(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public static void Substract(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }

        public static void Multiply()
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
        }

        public static void Divide()
        {
            Console.WriteLine($"{a} / {b} = {a / b}");
        }
       
    }
}
