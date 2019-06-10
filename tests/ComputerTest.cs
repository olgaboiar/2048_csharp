using csharp2048;
using NUnit.Framework;

namespace Tests
{
    public class ComputerTest
    {
        private Computer _testComp;
        private Board _board;

        [SetUp]
        public void Setup()
        {
            _testComp = new Computer();
            _board = new Board();
        }
        
        [Test]
        public void MoveSets2RandomlyOnTheBoard()
        {
            _testComp.Move(_board);
            Assert.AreEqual(15, _board.GetAvailableSpots().Count);
            Assert.Contains(2, _board.Spots);
        }
    }
}