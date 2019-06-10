namespace csharp2048
{
    public class UserInterface
    {
        private IUserInterface _ui;
        public UserInterface(IUserInterface ui)
        {
            _ui = ui;
        }
        
        public void Greet()
        {
            var greeting = "Hello! Lets play 2048! Try to get to 2048 tile!";
            _ui.Output(greeting);
        }
    }
}