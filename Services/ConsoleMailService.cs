namespace SampleNetCoreMVC.Services
{
    public class ConsoleMailService : IConsoleMailService
    {
        private readonly ILogger<ConsoleMailService> _logger;
        public ConsoleMailService(ILogger<ConsoleMailService> logger)
        {
            _logger = logger;
        }
        public void SendMessage(string recipient, string subject, string body)
        {
            //Log Message
            _logger.LogInformation($"To: {recipient} Subject: {subject} Body: {body}");
        }
    }
}
