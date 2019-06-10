using System.Collections.Generic;
using NUnit.Framework;
using csharp2048;

namespace Tests
{
    public class BoardTest
    {
        private Board _board;
        
        [SetUp]
        public void Setup()
        {
            _board = new Board();
        }

        [Test]
        public void Creation()
        {
            Assert.AreEqual(16, _board.Spots.Count);
        }

//        [Test]
//        public void GetSpotReturnsValueOfTheSpot()
//        {
//            _board.SetSpot(3, 'x');
//            _board.SetSpot(4, 'o');
//            
//            Assert.AreEqual(2,_board.GetSpot(2));
//            Assert.AreEqual('x',_board.GetSpot(3));
//            Assert.AreEqual('o',_board.GetSpot(4));
//        }

        [Test]
        public void SetSpotAssignsSpotValue()
        {
            _board.SetSpot(2, 16);
            var actual = _board.Spots[2];
            Assert.AreEqual(16, actual);
        }

        [Test]
        public void ReturnsListOfAvailableSpotsIndexesForEmptyBoard()
        {
            Assert.AreEqual(16, _board.GetAvailableSpots().Count);
            Assert.AreEqual(new List<object>() {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15}, _board.GetAvailableSpots());
        }
        
        [Test]
        public void ReturnsListOfAvailableSpotsIndexesForNotEmptyBoard()
        {
            Assert.AreEqual(16, _board.GetAvailableSpots().Count);
            
            _board.SetSpot(4, 32);
            
            Assert.AreEqual(15, _board.GetAvailableSpots().Count);
            Assert.AreEqual(new List<object>() {0,1,2,3,5,6,7,8,9,10,11,12,13,14,15}, _board.GetAvailableSpots());
        }
        

        [Test]
        public void ReturnsTrueIfSpotIsZero()
        {
            Assert.True(_board.IsAvailableSpot(0));
            Assert.False(_board.IsAvailableSpot(2));
            Assert.False(_board.IsAvailableSpot(2048));
        }
    }
}
