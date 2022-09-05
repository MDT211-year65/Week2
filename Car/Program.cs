using System;

public class Program {

 public static Car CreateCar(string band,
  string model,
  int numberOfDoors,
  int numberOfWheels) {
    return new Car(band,
    model,
    numberOfDoors,
    numberOfWheels);
 }
 public static void Main(string[] args) {
     Car myCar = CreateCar("Toyota", "Altis", 4, 4);
     Car benz = CreateCar("Benz", "Model 3", 2, 4);

     PrintCarInformation(myCar);
     PrintCarInformation(benz);
 }

 static void PrintCarInformation(Car car) {
    Console.WriteLine("**************************");
    Console.WriteLine("Band: {0}", car.band);
    Console.WriteLine("Model: {0}", car.model);
    Console.WriteLine("Number of Door: {0}", car.numberOfDoors);
    Console.WriteLine("Number of Wheels: {0}", car.numberOfWheels);
    Console.WriteLine(car.MoveForward());
    Console.WriteLine(car.MoveBackward());
    Console.WriteLine(car.Turn());
    Console.WriteLine(car.Stop());
    Console.WriteLine("**************************");
 }

}