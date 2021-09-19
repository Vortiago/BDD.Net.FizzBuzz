namespace BDD.Net.FizzBuzz
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var fizzBuzzHandler = new FizzBuzzHandler();
            Console.WriteLine(fizzBuzzHandler.InputFeedback(1));
        }
    }
}
