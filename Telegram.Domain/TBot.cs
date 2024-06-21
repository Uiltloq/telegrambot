using Telegram.Bot;
public class TBot
{
    public delegate void TBotHandler(string message);
    public event TBotHandler? Notify; 
    private readonly TelegramBotClient _client;
    public TBot(string token)
    {
        _client = new TelegramBotClient(token);
    }

    public async Task Start()
    {
        var me = await _client.GetMeAsync();
        Notify?.Invoke($"Hello, World! I am user {me.Id} and my name is {me.FirstName}.");
    }
}