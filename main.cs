using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Enter temperature in Celsius");
    double Celsius = Convert.ToDouble(Console.ReadLine());

    double Farenheit = (Celsius * 9/5) + 32;
    Console.WriteLine("Farenheit equivalent for "  +  Celsius + " degree celsius " + "is " + Farenheit);
    

   if(Farenheit>212)
  {
   Console.WriteLine("This temperature is above boiling point of 212 degree Farenheit ");
  }
   if(Farenheit<32) 
  {
   Console.WriteLine("This temperature is below the freezing point of 32 degrees Farenheit");
  }

  }
}