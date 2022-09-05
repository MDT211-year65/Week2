public class Car {
    public string band;
    public string model;
    public int numberOfDoors;
    public int numberOfWheels;

    public Car(string band,
     string model,
     int numberOfDoors,
     int numberOfWheels) {
        this.band = band;
        this.model = model;
        this.numberOfWheels = numberOfWheels;
        this.numberOfDoors = numberOfDoors;
    }
    
    public string MoveForward() {
        return "Move Forward";
    }

    public string MoveBackward() {
        return "Move Backward";
    }

    public string Stop() {
        return "Stop";
    }

    public string Turn() {
        return "Turn";
    }
}