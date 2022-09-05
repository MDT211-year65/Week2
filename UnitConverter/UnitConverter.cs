public class UnitConverter {
    private int ratio;

    public UnitConverter(int ratio) {
        this.ratio = ratio;
    }

    public int Convert(int unit) {
        return unit * this.ratio;
    }
}