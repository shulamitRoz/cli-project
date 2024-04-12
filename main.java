import java.util.Scanner;

public class main {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        char type;
        String name;
        int floor,size=0,numR,apartNum,terrace=0,totalArea=terrace+size,garden;
        boolean flag =true;
        build buildArr[]=new build[50];
        for (int i = 0; i <buildArr.length ; i++) {
            System.out.println("enter1 for standar, 2 for penthous and 3 for garden ");
                type=in.next().charAt(0);
            System.out.println("insert the Details of your apartment");
            name=in.next(); floor=in.nextInt();size=in.nextInt();numR=in.nextInt();apartNum= in.nextInt();terrace=in.nextInt();
            garden=in.nextInt();

             if (type==1){
                 apartment a=new apartment(name,floor,size,numR,apartNum);
                 buildArr[i].addAprtment(a);
                 System.out.println("num of rooms"+" "+numR);
             }
             else if (type==2){
                 penthouse p=new penthouse(name,floor,size,numR,terrace,totalArea,apartNum) ;
                 buildArr[i].addAprtment(p);
                 System.out.println("the size of terrace"+terrace);
             } else  {

                 garden g=new garden(name,1,size,numR,garden,flag,totalArea,apartNum);
                 buildArr[i].addAprtment(g);
                 System.out.println("the garden size"+ garden);
                 System.out.println("douse the garden have a enter"+flag);
             }

        }
    }
}
