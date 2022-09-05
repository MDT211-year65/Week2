using System;

public class Program {

 public static void Main(string[] args) {
     UnitConverter feetToInchesConverter = new UnitConverter(12);
     UnitConverter milesToFeetConverter = new UnitConverter(5280);

     Console.WriteLine("Feet to inches: {0}",
      feetToInchesConverter.Convert(30));
     Console.WriteLine("Miles to Feet: {0}",
      milesToFeetConverter.Convert(1));
     Console.WriteLine("Feet to Inches from miles: {0}",
     feetToInchesConverter.Convert(milesToFeetConverter.Convert(2)));
 }

}