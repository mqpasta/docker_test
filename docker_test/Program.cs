using System;

namespace docker_test
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            do
            {
                Console.WriteLine("Hello World!");
                Console.Write("Press Y to continue:");
                ch = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (ch == 'Y' || ch == 'y');
        }
    }
}
