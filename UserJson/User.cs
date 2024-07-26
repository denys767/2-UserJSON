using System.Text.RegularExpressions;
using System.Linq;

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
      throw new ArgumentException("Нельзя ввести что-то кроме строки", nameof(NameGet));
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
      throw new ArgumentException("Гой иди нах, введи адекватный E-mail");
    }
  }

  public void SetAge()
  {
    Console.WriteLine("Введите возраст:");
    Age = int.Parse(Console.ReadLine());
  }

}