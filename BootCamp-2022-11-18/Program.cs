// // dotnet add package Newtonsoft.Json 
// Клиентский код
//  https://core.telegram.org/bots/api#available-methods
string token = File.ReadAllText("token.config");

TelegramBot bot = new TelegramBot(token);

void Updates(TelegramMessageModel msg)
{
  bot.SendMessage(msg.chatId, $"{msg.text}: получено");
}

bot.action = Updates;

bot.Start();

System.Console.WriteLine("++++");

