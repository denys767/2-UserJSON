class Age
{
  public int UserNumber;
  public void SetAge()
  {
    Console.WriteLine("Введите возраст:");
    int AgeInt = int.Parse(Console.ReadLine());
    UserNumber = AgeInt;
  }
}