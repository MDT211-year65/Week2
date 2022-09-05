namespace Test_Dog_Door;

public class UnitTest1
{
    [Fact]
    public void TestOpen() {
        DogDoor door = new DogDoor();
        door.Open();

        Assert.Equal(door.IsOpen(), true);
    }

    [Fact]
    public void TestClose() {
        DogDoor door = new DogDoor();
        door.Close();

        Assert.Equal(door.IsOpen(), false);
    }

    [Fact]
    public void TestCloseWhenDoorIsOpen() {
        DogDoor door = new DogDoor();
        door.Open();
        door.Close();

        Assert.Equal(door.IsOpen(), false);
    }
}