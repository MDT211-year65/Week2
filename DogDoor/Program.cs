using System;

public class Program {

 public static void Main(string[] args) {
    DogDoor door = new DogDoor();
    door.Open();
    door.Close();
    Console.WriteLine("Door is open ? : {0}", door.IsOpen());
 }

}