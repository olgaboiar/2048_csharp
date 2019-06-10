using csharp2048;

namespace Tests
{
    public class ConsoleMock : IUserInterface
    {
        public int numTimesOutputCalled = 0;
//        public int numTimesReadInputCalled = 0;

        public void Output(string message)
        {
            numTimesOutputCalled++;
        }

        public string ReadInput()
        {
//            numTimesReadInputCalled++;
            return "5";
        }
    }

}