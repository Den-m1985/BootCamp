using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

// Разбор модели JSON

public class JsonParser
{
  string content;

  public TelegramMessageModel[] GetMessage(string content)
  {
    List<TelegramMessageModel> msgs = new();

    JToken[] data = JObject.Parse(content)["result"].ToArray();

    foreach (dynamic item in data)
    {
      long id = item.message.from.id;
      string text = item.message.text;
      long updateId = item.update_id;
      string firstName = item.message.from.first_name;
      msgs.Add(new(id, firstName, text, updateId));   // добавляем в результирующий List<TelegramMessageModel>
    }
    return msgs.ToArray();
  }
}