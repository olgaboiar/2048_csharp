using System;

namespace csharp2048
{
    public class Computer : IPlayer
    {
        public void Move(Board board)
        {
            Random rnd = new Random();
            Int32 spot = rnd.Next(board.GetAvailableSpots().Count);
            board.SetSpot(spot, 2);
        }
    }
}