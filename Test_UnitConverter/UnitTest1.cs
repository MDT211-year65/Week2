namespace Test_UnitConverter;

public class UnitTest1
{
    [Fact]
    public void TestFeetToInchesConverter() {
        UnitConverter feetToInchesConverter = new UnitConverter(12);

        int result = feetToInchesConverter.Convert(30);

        Assert.Equal(result, 360);
    }

    [Fact]
    public void TestMilesToFeetConverter() {
        UnitConverter milesToFeetConverter = new UnitConverter(5280);

        int result = milesToFeetConverter.Convert(1);

        Assert.Equal(result, 5280);
    }

    [Fact]
    public void TestFeetToInchesFromMilesConverter() {
        UnitConverter feetToInchesConverter = new UnitConverter(12);
        UnitConverter milesToFeetConverter = new UnitConverter(5280);

        int result = feetToInchesConverter.Convert(milesToFeetConverter.Convert(2));

        Assert.Equal(result, 126720);
    }
}