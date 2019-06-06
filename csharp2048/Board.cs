using System.Collections.Generic;

namespace csharp2048
{
    public class Board
    {
        public List<object> Spots;
        
        public Board()
        {
            Spots = new List<object>() {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '};
        }
    }
}