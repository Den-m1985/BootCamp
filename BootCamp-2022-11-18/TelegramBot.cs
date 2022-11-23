// Работа с логикой получения/отправка сообщений

public class TelegramBot
{
  string token;
  public Action<TelegramMessageModel> action; //действие завязанное на TelegramMessageModel
  HttpClient hc;
  Thread thread;

  public TelegramBot(string token)
  {
    this.token = token;
    hc = new HttpClient();
    hc.BaseAddress = new Uri($"http://api.telegram.org/bot{token}/");
    thread = new Thread(GetUpdates); // отдельный поток чтоб на методе Start он не завис, а продолжал работать.
  }

  private void GetUpdates()   // метод отвечает за разбор всего
  {
    long offset = 0;  // помечает сообщения как прочитанные
    while (true)  // бесконечный цикл
    {
      // получаем данные
      string content = hc.GetStringAsync($"getupdates?offset={offset + 1}").Result;
      try   // если придет вместо сооб
      {
        // разбор JSON и получаем массив
        TelegramMessageModel[] ms = new JsonParser().GetMessage(content);
        if (ms.Length != 0)  // если есть хоть один элемент
        {
          foreach (var item in ms)
          {
            Console.WriteLine(item);  // распечатываем
            action(item);             // применяю действие из Program.cs / void Updates()
            offset = item.updateId;
          }
        }
      }
      catch
      {
        Console.WriteLine("ОШИБКА !!!"); 
      }
      Thread.Sleep(1000);   // задержка на отправку сообщения 1с чтоб не забанили.
    }

  }

  public void SendMessage(long userId, string text)
  {
    //..НАДО РЕАЛИЗОВАТЬ
  }

  public void Start()
  {
    thread.Start();
  }
}