public class garden extends apartment{

    private int gardenS;
    private boolean enter;
    private int totalArea;

    @Override
    public String toString() {
        return "garden{" +
                "gardenS=" + gardenS +
                ", enter=" + enter +
                ", totalArea=" + totalArea +
                ", name='" + name + '\'' +
                ", floor=" + floor +
                ", size=" + size +
                ", numR=" + numR +
                '}';
    }

    public int getGardenS() {
        return gardenS;
    }

    public void setGardenS(int gardenS) {
        this.gardenS = gardenS;
    }

    public boolean isEnter() {
        return enter;
    }

    public void setEnter(boolean enter) {
        this.enter = enter;
    }

    public int getTotalArea() {
        return totalArea;
    }

    public void setTotalArea(int totalArea) {
        this.totalArea = totalArea;
    }

    public garden(String name, int floor, int size, int numR, int gardenS, boolean enter, int totalArea,int apartNum) {
        super(name, floor, size, numR,apartNum);
        this.gardenS = gardenS;
        this.enter = enter;
        this.totalArea = gardenS+getSize();
    }
}
