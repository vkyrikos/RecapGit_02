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
    }
}
