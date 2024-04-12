import java.util.Scanner;

public class tar16 {
    public static void travel (int girls,int bus,int desk,int shipe){
        int b=0,d=0,s=0;
        if (girls/bus==0)
          b=girls/bus;
        else
            b=1+girls/bus;
        if (girls/desk==0)
            d=girls/desk;
        else
           d=1+girls/desk;
        if (girls/shipe==0)
            s=girls/shipe;
        else
            s=1+girls/shipe;
        System.out.println("bus"+" "+b);
        System.out.println("desk"+" "+d);
        System.out.println("shipe"+" "+s);
    }

    public static void main(String[] args) {
        Scanner in =new Scanner(System.in);
        int girls,bus,shipe,desk;
        System.out.println("insert num of girls");
        girls=in.nextInt();
        System.out.println("insert num of bus");
        bus=in.nextInt();
        System.out.println("insert num of desk");
        desk=in.nextInt();
        System.out.println("insert num of shipe");
        shipe=in.nextInt();
        travel(girls,bus,desk,shipe);
    }
}
