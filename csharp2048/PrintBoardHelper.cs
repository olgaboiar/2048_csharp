using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp2048
{
    public class PrintBoardHelper
    {
        public string StringifyBoard(Board board)
        {
            List<string> StringArray = GetStringArray(board);
            int max = GetLargestNumber(board);
            List<string> ArrayWithSpaves = AddSpaces(StringArray, max);
//                    divide into rows
//                        add bars between rows
//                        add lines between rows
//                        assemble everything
            return "bla";
        }

        public List<string> GetStringArray(Board board)
        {
            return board.Spots.Select(s => s.ToString()).ToList();
        }
        
        public int GetLargestNumber(Board board)
        {
            return board.Spots.Max().ToString().Length;
        }

        public List<string> AddSpaces(List<string> stringBoard, int max)
        {
            List<string> modifiedList = new List<string>();
            foreach (string item in stringBoard)
            {
                if (item.Length < max)
                {
                    string modifiedItem = item + new string (' ', (max - item.Length));
                    modifiedList.Add(modifiedItem);
                }
                else
                {
                    modifiedList.Add(item);
                }
            }

            return modifiedList;
        }
    }
}