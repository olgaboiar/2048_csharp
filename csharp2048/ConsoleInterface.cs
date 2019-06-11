using System;

namespace csharp2048
{
    public class ConsoleInterface : IUserInterface
    {
        public void Output(string message)
        {
            Console.WriteLine(message);
        }

        public string ReadInput()
        {
            return Console.ReadLine();
        }

        public ConsoleKey ReadArrow()
        {
            return Console.ReadKey(true).Key;
        }
    }
}