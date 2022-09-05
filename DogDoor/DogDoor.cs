public class DogDoor {
    private bool open;

    public DogDoor() {
        this.open = false;
    }

    public void Open() {
        Console.WriteLine("The dog door is Open.");
        this.open = true;
    }

    public void Close() {
        Console.WriteLine("The dog door is Close.");
        this.open = false;
    }

    public bool IsOpen() {
        return this.open;
    }

}