namespace csharp2048
{
    public interface IUserInterface
    {
        void Output(string message);
        string ReadInput();
    }
}