using System;


public class Clock
{
  public void Run()
  {
    Console.WriteLine("Enter Hour: ");
    string inputtedHour = Console.ReadLine();
    int Hour = int.Parse(inputtedHour);
    Console.WriteLine("Enter Minutes: ");
    string inputtedMinutes = Console.ReadLine();
    int Minutes = int.Parse(inputtedMinutes);

    int hourDegree = (Hour * 30);
    int minuteDegree = (Minutes * 6);

      if(Hour < 0 || Hour > 12)
      {
        Console.WriteLine("please enter a number 0-12");
      }
      if(Minutes < 0 || Minutes > 59)
      {
        Console.WriteLine("Please enter a number 0-59");
      }
      if (hourDegree > minuteDegree)
      {
        Console.WriteLine(hourDegree - minuteDegree + " degrees");
      }
      if (minuteDegree > hourDegree)
      {
        Console.WriteLine(minuteDegree - hourDegree + " degrees");
      }
      if (hourDegree == minuteDegree)
      {
        Console.WriteLine("Zero Degrees");
      }
    }
  }
public class Program
{
  public static void Main()
  {
    Clock time = new Clock();
    time.Run();
  }
}
