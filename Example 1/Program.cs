using System;

namespace Example_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Find cube!");
                Console.WriteLine("Enter a number");
                var num = int.Parse(Console.ReadLine());
                Console.WriteLine($"Cube of {num} is {num * num * num}");
            }
            catch
            {
                Console.Write(Console.Error);
                  }
            finally
            {
                Console.WriteLine("Re-enter just a number!");
                Console.ReadLine();
            }
    }
    }
}
