class User
{
  public string UserName { get; set; }
  public string UserMail { get; set; }
  public int UserAge { get; set; }
  public void SetUserData()
  {
    Console.WriteLine("Введите имя пользователя:");
    string Name = Console.ReadLine();

    if (Name == "" || int.TryParse(Name, out _) || double.TryParse(Name, out _)) //"out _" - означає що отримане значення непотрібне. Tryparse виводить bool: "Чи є вміст MailString числом?"
    //Я без ідей, що треба зробити щоб кидалася помилка при дробу через крапку
    {
      throw new ArgumentException("Нельзя ввести что-то кроме строки", nameof(Name));
    }

    else
    {
      UserName = Name;
    }
  }


  public void SetUserMail()
  {
    Console.WriteLine("Введите почту пользователя:");
    string MailString = Console.ReadLine();

    if (MailString == "" || int.TryParse(MailString, out _) || float.TryParse(MailString, out _)) //"out _" - означає що отримане значення непотрібне. Tryparse виводить bool: "Чи є вміст MailString числом?"
    {
      throw new ArgumentException("Нельзя ввести что-то кроме строки", nameof(MailString));
    }
    else
    {
      UserMail = MailString;
    }
  }

  public void SetAge()
  {
    Console.WriteLine("Введите возраст:");
    UserAge = int.Parse(Console.ReadLine());
  }

}