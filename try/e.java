import java.util.Scanner;

public class tar20 {
    public  static void salary ( int student){
        int salary=0;
        if (student<=10)
         salary+=20*180;
        else
            salary+=20*180+5*(student-10);
        System.out.println(salary);
    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int student;
        System.out.println("insert num of student");
        student=in.nextInt();
        salary(student);
    }
}
