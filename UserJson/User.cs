using System.Text.RegularExpressions;

class User
{
  public string Name { get; set; }
  public string Mail { get; set; }
  public int Age { get; set; }
  public void SetUserName()
  {
    Console.WriteLine("Введите имя пользователя:");
    string NameGet = Console.ReadLine();

    if (NameGet == "" || int.TryParse(NameGet, out _) || double.TryParse(NameGet, out _)) //"out _" - означає що отримане значення непотрібне. Tryparse виводить bool: "Чи є вміст MailString числом?"
    //Я без ідей, що треба зробити щоб кидалася помилка при дробу через крапку
    {
      Console.WriteLine("Повторите попытку.");
      SetUserName();
    }

    else
    {
      Name = NameGet;
    }
  }


  public void SetUserMail()
  {
    Console.WriteLine("Введите почту пользователя:");
    string MailValidate;
    MailValidate = Console.ReadLine();
    Regex validateEmailRegex = new Regex("^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$");
    if (validateEmailRegex.IsMatch(MailValidate))
    {
      Mail = MailValidate;
    }
    else
    {
      Console.WriteLine("Повторите попытку.");
      SetUserMail();
    }
  }

  public void SetAge()
  {
    Console.WriteLine("Введите возраст:");
    string AgeValidate = Console.ReadLine();
    if (int.TryParse(AgeValidate, out _))
    {
      Age = int.Parse(AgeValidate);
    }
    else
    {
      Console.WriteLine("Повторите попытку.");
      SetAge();
    }
  }

}