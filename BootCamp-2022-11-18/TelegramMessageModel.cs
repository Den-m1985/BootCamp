
// здесь хранится модель сообщений
public class TelegramMessageModel
{
  public long updateId;
  public long chatId;  //id куда мы посылаем сообщения
  public string text;  //текст куда мы посылаем сообщения
  public string firstName;  //имя куда мы посылаем сообщения

//конструктор позволяющий удобно инициализировать TelegramMessageModel
  public TelegramMessageModel(long chatId, string firstName, string messageText, long updateId)
  {
    this.chatId = chatId;
    this.firstName = firstName;
    this.text = messageText;
    this.updateId = updateId;
  }
    
  public override string ToString()
  {
    return $"{firstName} {text} {chatId}  {updateId} ";
  }

}