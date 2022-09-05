namespace Test_Car;

public class UnitTest1
{
    [Fact]
    public void TestMoveForward() {
        Car myCar = new Car();

        Assert.Equal(myCar.MoveForward(), "Move Forward");
    }

    [Fact]
    public void TestMoveBackward() {
        Car myCar = new Car();

        Assert.Equal(myCar.MoveBackward(), "Move Backward");
    }

    [Fact]
    public void TestStop() {
        Car myCar = new Car(); 

        Assert.Equal(myCar.Stop(), "Stop");
    }

    [Fact]
    public void TestTurn() {
        Car myCar = new Car();

        Assert.Equal(myCar.Turn(), "Turn");
    }

}