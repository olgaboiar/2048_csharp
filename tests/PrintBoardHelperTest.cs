using System;
using System.Collections.Generic;
using System.Linq;
using csharp2048;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class PrintBoardHelperTest
    {
        private Board _board;
        private Board _board2048;
        private PrintBoardHelper _helper;
        
        [SetUp]
        public void Setup()
        {
            _board = new Board();
            _helper = new PrintBoardHelper();
            _board2048 = new Board();
            _board2048.Spots = new List<Int32>() {
                2, 4, 16, 8, 16, 32, 64, 128, 256, 1024, 2048, 2, 4, 8, 16, 32
            }
            ;
        }

        [Test]
        public void ReturnSpotsAsArrayOfStrings()
        {
            var actual = _helper.GetStringArray(_board);
            Assert.AreEqual(new List<string>() {"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"}, actual);
        }

        [Test]
        public void ReturnsTheLargestNumber()
        {
            Int32 actual = _helper.GetLargestNumber(_board2048);
            Assert.AreEqual( 4, actual);
        }


        [Test]
        public void AddsSpacesToAllSpots()
        {
            var stringBoard = _helper.GetStringArray(_board2048);
            var max = _helper.GetLargestNumber(_board2048);
            var actual = _helper.AddSpaces(stringBoard, max);
            Assert.AreEqual(new List<string>() {"2   ","4   ","16  ","8   ","16  ","32  ","64  ","128 ","256 ","1024","2048","2   ","4   ","8   ","16  ","32  "}, actual);
        }
        

        
    }
}