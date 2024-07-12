class Mail
{
    public string UserMail;
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
}