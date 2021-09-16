using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter temperature in Celsius");
    double Celsius = Convert.ToDouble(Console.ReadLine());
double farenheit = (Celsius * (9/5)) + 32;  
Console.WriteLine("Farenheit equivalent for " + Celsius + " degree in Celsius is  " + farenheit + ".");

if (farenheit < 32){
  Console.WriteLine("This temperature is below freezing of 32 degree Farenheit.");
} 
else if (farenheit > 212 ){
  Console.WriteLine("This temperature is above boiling point of 212 degree Farenheit.");
}

  }
}