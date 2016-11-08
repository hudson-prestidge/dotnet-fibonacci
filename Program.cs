using System;
using TestNewFile;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            NumberGenerator numGen = new NumberGenerator();
            for(int i = 0; i < 10; i++) {
                numGen.NewNumber();
            }
        }
    }
}
