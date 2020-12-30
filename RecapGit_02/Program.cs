using System;

namespace RecapGit_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Print();
            Customer customer = new Customer()
            {
                FirstName = "Vasileios",
                LastName = "Kyrikos",
                Age = 32,
                Address = "Vonitsas",
                Id = 1
            };
        }
        static void Print()
        {
            Console.WriteLine("Hello World");
        }
        static void TestMethod()
        {
            Console.WriteLine("Testing grounds");
        }
        static int Addition(int number0, int number1)
        {
            return number0 + number1;
        }
        static void Something()
        {
            Console.WriteLine("SOmething");
        }

        static int Subtraction(int number0, int number1)
        {
            return number0 - number1;
        }
        static int Multiplication(int number0, int number1)
        {
            return number0 * number1;
        }
        static double Division(int number0, int number1)
        {
            return number0 / number1;
        }
        static void Truth()
        {
            Console.WriteLine("Me I always tell the truth, even when I lie.");
        }
    }
}
