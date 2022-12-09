namespace SampleNetCoreMVC.Services
{
    public interface IConsoleMailService
    {
        void SendMessage(string recipient, string subject, string body);
    }
}