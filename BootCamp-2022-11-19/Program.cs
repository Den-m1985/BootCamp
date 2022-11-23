// // dotnet add package Newtonsoft.Json 
string token = File.ReadAllText("token.config");

TelegramBot bot = new TelegramBot(token);

void Updates(TelegramMessageModel msg)
{
  bot.SendMessage(msg.chatId, $"{msg.text}: получено", msg.replyToMessageId);
}

bot.action = Updates;

bot.Start();

System.Console.WriteLine("++++");

