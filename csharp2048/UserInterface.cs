using System;

namespace csharp2048
{
    public class UserInterface
    {
        private IUserInterface _ui;
        private PrintBoardHelper _printBoardHelper;
        public UserInterface(IUserInterface ui)
        {
            _ui = ui;
            _printBoardHelper = new PrintBoardHelper();
        }
        
        public void Greet()
        {
            var greeting = "Hello! Lets play 2048! Try to get to 2048 tile!";
            _ui.Output(greeting);
        }

        public ConsoleKey GetDirection()
        {
            return _ui.ReadArrow();
        }

        public void PrintBoard(Board board)
        {
//            string boardToPrint = do somethingwith
            _printBoardHelper.StringifyBoard(board);
            _ui.Output("board");
        }
    }
}