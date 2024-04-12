
public class  penthouse extends apartment{

    @Override
    public String toString() {
        return "penthouse{" +
                "Terrace=" + Terrace +
                ", totalArea=" + totalArea +
                ", name='" + name + '\'' +
                ", floor=" + floor +
                ", size=" + size +
                ", numR=" + numR +
                '}';
    }

    private int Terrace;
    private int totalArea;

    public int getTerrace() {
        return Terrace;
    }

    public void setTerrace(int terrace) {
        Terrace = terrace;
    }

    public int getTotalArea() {
        return totalArea;
    }

    public void setTotalArea(int totalArea) {
        this.totalArea = totalArea;
    }

    public penthouse(String name, int floor, int size, int numR, int terrace, int totalArea,int apartnum) {
        super(name, floor, size, numR,apartnum);
        Terrace = terrace;
        this.totalArea =Terrace+size ;
    }
}
