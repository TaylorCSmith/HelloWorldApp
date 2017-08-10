using System;

namespace ConsoleApp1
{
    class HelloWorld : IHelloWorld
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void Run(string[] arguments)
        {
            this.logger.Info
        }
    }
}