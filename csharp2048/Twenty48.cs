using System;

namespace csharp2048
{
    public class Twenty48
    {
        public void Run()
        {
            ConsoleInterface console = new ConsoleInterface();
            UserInterface ui = new UserInterface(console);
            Board board = new Board();
            Game game = new Game(ui, board);
            ui.Greet();
            game.Initialize();
            game.Play();
//            game.DeclareWinner();
        } 
    }
}