import java.util.Scanner;

public class tar17 {
    public static int coumon (int n1,int n2,int x){
        for (int i = 2; i <9 ; i++) {
            if (n1%i==0&&n2%i==0){
                 x=i;
                 i=10;
            }
            else
                x=1;
        }
        return x;

    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int num1,num2,x=0,cnt=0;
        System.out.println("insert 2 numbers");
        num2=in.nextInt();
        num1=in.nextInt();
        for (int i = 1; i <=2 ; i++) {
            if(coumon(num1,num2,x)==1)
                cnt++;
            System.out.println("insert 2 numbers");
            num2=in.nextInt();
            num1=in.nextInt();
        }
        System.out.println(cnt);
//        coumon(num1,num2,x);
//        System.out.println(coumon(num1,num2,x));
    }
}
