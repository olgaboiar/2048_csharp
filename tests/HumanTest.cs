using csharp2048;
using NUnit.Framework;

namespace Tests
{
    public class HumanTest
    {
        private UserInterface _ui;
        private Human _testHuman;
        private Board _board;
        private ConsoleMock _consoleMock;
        
        [SetUp]
        public void Setup()
        {
            _consoleMock = new ConsoleMock();
            _ui = new UserInterface(_consoleMock);
            _testHuman = new Human(_ui);
            _board = new Board();
        }
        
        [Test]
        public void MoveIsCalledWithUiReadInputMethods()
        {
            _testHuman.Move(_board);
            Assert.AreEqual(1, _consoleMock.numTimesReadArrowCalled);
        }
    }
}