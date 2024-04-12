public class apartment {
    public apartment(String name, int floor, int size, int numR,int apartNum) {
        this.name = name;
        this.floor = floor;
        this.size = size;
        this.numR = numR;
        this.apartNum=apartNum;
    }

    @Override
    public String toString() {
        return "apartment{" +
                "name='" + name + '\'' +
                ", floor=" + floor +
                ", size=" + size +
                ", numR=" + numR +
                '}';
    }

    protected   String name;
    protected int floor;

    protected int size;
    protected int numR;

    public int getApartNum() {
        return apartNum;
    }

    public void setApartNum(int apartNum) {
        this.apartNum = apartNum;
    }

    protected int apartNum;
    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getFloor() {
        return floor;
    }

    public void setFloor(int floor) {
        this.floor = floor;
    }

    public int getSize() {
        return size;
    }

    public void setSize(int size) {
        this.size = size;
    }

    public int getNumR() {
        return numR;
    }

    public void setNumR(int numR) {
        this.numR = numR;
    }


}
