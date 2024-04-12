import java.util.Arrays;

public class build {
    private String namS;
    private int numP;
    private apartment[] arrAprt;


    public build(String namS, int numP, apartment[] arrAprt, int numOfApart) {
        this.namS = namS;
        this.numP = numP;
        this.arrAprt = new apartment[numOfApart];

    }

    //פעולה המוסיפה דירה לבנין
    public void addAprtment(apartment a) {
        arrAprt[a.getApartNum()] = a;
    }

    //פעולה שבודקת כמה דירות פנטהאוס יש
    public int penthousAprt() {
        int cnt = 0;
        for (int i = 0; i < arrAprt.length; i++) {
            if (arrAprt[i] instanceof penthouse)
                cnt++;
        }
        return cnt;
    }

    //פעולה המחזירה שטח כולל של גינות בבנין
    public int sumGarden() {
        int sum = 0;
        for (int i = 0; i < arrAprt.length; i++) {
            if (arrAprt[i] instanceof garden)
                sum += ((garden) arrAprt[i]).getGardenS();
        }
        return sum;
    }

    //פעולה המחזירה את הדירה עפ שם שהתקבל
    public apartment nameOner(String name) {
        for (int i = 0; i < arrAprt.length; i++) {
            if (arrAprt[i].getName().equals(name))
                return arrAprt[i];
        }
        return null;
    }

    @Override
    public String toString() {
        return "build{" +
                "namS='" + namS + '\'' +
                ", numP=" + numP +
                ", arrAprt=" + Arrays.toString(arrAprt) +
                '}';
    }

    public int ifEmpty() {
        int cnt = 0;
        for (int i = 0; i < arrAprt.length; i++) {
            if (arrAprt[i].getName().equals(" ")) ;
            cnt++;
        }
        return cnt;
    }

    public int sumSize() {
        int sum = 0;
        for (int i = 0; i < arrAprt.length; i++) {
            if (arrAprt[i] instanceof penthouse)
                sum += ((penthouse) arrAprt[i]).getTotalArea()
            else if (arrAprt[i] instanceof garden) {
                sum += ((garden) arrAprt[i]).getTotalArea();
            } else sum += arrAprt[i].getSize();
        }
        return sum;
    }

}
