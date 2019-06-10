using System;
using System.Collections.Generic;

namespace csharp2048
{
    public class Board
    {
        public List<Int32> Spots;
        
        public Board()
        {
            Spots = new List<Int32>() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        }

        public List<object> GetAvailableSpots()
        {
            List<object> availableSpots = new List<object>();
            int index = 0;
            foreach (Int32 spot in Spots)
            {
                if (IsAvailableSpot(spot)) availableSpots.Add(index);
                index++;
            }
            return availableSpots;
        }

        public void SetSpot(int spot, int value)
        {
            Spots[spot] = value;
        }
        
        public bool IsAvailableSpot(Int32 spot)
        {
            return spot == 0;
        }
    }
}