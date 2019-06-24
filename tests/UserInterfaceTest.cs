using csharp2048;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class UserInterfaceTest
    {
        private UserInterface _ui;
        private ConsoleMock _consoleMock;
        
        [SetUp]
        public void Setup()
        {
            _consoleMock = new ConsoleMock();
            _ui = new UserInterface(_consoleMock);
        }
        
        [Test]
        public void GreetIsCalledWithUiOutput()
        {
            _ui.Greet();
            Assert.AreEqual(1, _consoleMock.numTimesOutputCalled);

        } 
        
        [Test]
        public void PrintBoardIsCalledWithUiOutput()
        {
            Board board = new Board();
            _ui.PrintBoard(board);
            Assert.AreEqual(1, _consoleMock.numTimesOutputCalled);
        }
    }
}