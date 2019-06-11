using System;
using csharp2048;

namespace Tests
{
    public class ConsoleMock : IUserInterface
    {
        public int numTimesOutputCalled = 0;
        public int numTimesReadInputCalled = 0;
        public int numTimesReadArrowCalled = 0;

        public void Output(string message)
        {
            numTimesOutputCalled++;
        }

        public string ReadInput()
        {
            numTimesReadInputCalled++;
            return "U";
        }

        public ConsoleKey ReadArrow()
        {
            numTimesReadArrowCalled++;
            return ConsoleKey.UpArrow;
        }
    }

}