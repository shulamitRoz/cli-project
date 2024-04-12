using System;

namespace  Enum;

internal class Program
{
    static void Main(string[] args)
    {

        //Seasons s1 = Seasons.Autumn;
        //Seasons s2 = Seasons.summer;
        //Seasons s3 = s2;
        //Console.WriteLine("{0 }{1}{2}", s1, s2, s3);
        //s2 = Seasons.winter;
        //Console.WriteLine(s2);
        //s1.Equals(s2);

        Console.WriteLine("insert day for shift");
        Shift myShift = new Shift(int.Parse(Console.ReadLine()));
        Console.WriteLine(myShift.day);

  
        Shift shift3.day = WeekDay.Tuesday | WeekDay.monday;


       
    }
    public class Date
    {
        WeekDay day=WeekDay.sunday;

    }
    public class Shift
    {
        public string Day { get; set;}
        public WeekDay day;
        public Shift(int shiftD)
        {
            day = (WeekDay)shiftD;
        }

    



    }
    public static void print_value(WeekDay day)
    {
        for (int i = 0; i < 64; i++)
        {
            if(i==day.)
        }
    }


}