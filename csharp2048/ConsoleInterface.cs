using System;

namespace csharp2048
{
    public class ConsoleInterface
    {
        public void Output(string message)
        {
            Console.WriteLine(message);
        }

        public string ReadInput()
        {
            return Console.ReadLine();
        }
    }
}