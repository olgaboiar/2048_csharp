using csharp2048;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class GameTest
    {
        private Game _testGame;
        private ConsoleMock _consoleMock;
        private UserInterface _ui;
        private Board _testBoard;
        
        [SetUp]
        public void SetUp()
        {
            _consoleMock = new ConsoleMock();
            _ui = new UserInterface(_consoleMock);
            _testBoard = new Board();
            _testGame = new Game(_ui, _testBoard);
        }

        [Test]
        public void CreatesPlayers()
        {
            _testGame.Initialize();
            
            Assert.IsNotNull(_testGame.HumanPlayer);
            Assert.IsInstanceOf(typeof(Human), _testGame.HumanPlayer);
            
            Assert.IsNotNull(_testGame.ComputerPlayer);
            Assert.IsInstanceOf(typeof(Computer), _testGame.ComputerPlayer);
        }
    }
}