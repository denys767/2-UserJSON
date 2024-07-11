class Age 
{
  public int UserNumber;
  public void SetAge() {
    Console.WriteLine ("Введите возраст:");
    int AgeInt =  Convert.ToInt32(Console.ReadLine());
    UserNumber = AgeInt;
}
}