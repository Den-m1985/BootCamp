public class TelegramBot
{
  string token;
  public Action<TelegramMessageModel> action;
  HttpClient hc;
  Thread thread;

  public TelegramBot(string token)
  {
    this.token = token;
    hc = new HttpClient();
    hc.BaseAddress = new Uri($"http://api.telegram.org/bot{token}/");
    thread = new Thread(GetUpdates);
  }

  private void GetUpdates()
  {
    long offset = 0;
    while (true)
    {
      string content = hc.GetStringAsync($"getupdates?offset={offset + 1}").Result;
      try
      {
        TelegramMessageModel[] ms = new JsonParser().GetMessage(content);
        if (ms.Length != 0)
        {
          foreach (var item in ms)
          {
            Console.WriteLine(item);
            action(item);
            offset = item.updateId;
          }
        }
      }
      catch
      {
        Console.WriteLine("ОШИБКА !!!");
      }
      Thread.Sleep(1000);
    }

  }

  public void SendMessage(long userId, string text, long replyToMessageId)
  {
    String content = String.Empty;
    //$"sendMessage?chat_id={userId}&text={text}&reply_to_message_id={replyToMessageId}"
    content = String.Format(
      // после ? пишутся параметры GET. Если несколько параметров, то амперсант &
    @"sendMessage?chat_id={0}&text={1}&reply_to_message_id={2}",
      userId, //0
      text, //1
      replyToMessageId
    );
    System.Console.WriteLine(content);
    var res = hc.GetStringAsync(content).Result;
    System.Console.WriteLine(res);
  }

  public void Start()
  {
    thread.Start();
  }
}
