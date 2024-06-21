void DisplayMessage(string message) => Console.WriteLine(message);
var bot = new TBot("");
bot.Notify += DisplayMessage;
await bot.Start();