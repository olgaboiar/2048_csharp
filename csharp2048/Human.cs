using System;

namespace csharp2048
{
    public class Human : IPlayer
    {
        private UserInterface _ui;

        public Human(UserInterface ui)
        {
            _ui = ui;
        }
        
        public void Move(Board board)
        {
            ConsoleKey direction = _ui.GetDirection();
        }
    }
}