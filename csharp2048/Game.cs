namespace csharp2048
{
    public class Game
    {
        private UserInterface _ui;
        private Board _board;
        public Human HumanPlayer;
        public Computer ComputerPlayer;
        
//        public IPlayer CurrentPlayer;

        public Game(UserInterface ui, Board board)
        {
            _ui = ui;
            _board = board;
            HumanPlayer = null;
            ComputerPlayer = null;
//            CurrentPlayer = null;
        }

        public void Initialize()
        {
            HumanPlayer = new Human(_ui);
            System.Console.WriteLine("human created");
            ComputerPlayer = new Computer();
            System.Console.WriteLine("comp created");
        }

        public void Play()
        {
            ComputerPlayer.Move(_board);
//            ui print board
            HumanPlayer.Move(_board);
//            evluate board
        }
    }
}