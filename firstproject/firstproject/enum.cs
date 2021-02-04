//author:BHSV
//date:4-2-21
using System;
//enum program
namespace Enum
{

    enum Week
    {
        //declarring enum constants
        sun,
        mon,
        tue,
        wed,
        thu,
        fri,
        sat
    }
    class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("the enum value of 1st day" + (int)Week.sun);//prints op in integer as 0
            Console.WriteLine("the enum value of 2nd day" + (int)Week.mon);
            Console.WriteLine("the enum value of 3rd day" + (int)Week.tue);
            Console.WriteLine("the enum value of 4th day" + (int)Week.wed);
            Console.WriteLine("the enum value of 5th day" + (int)Week.thu);
            Console.WriteLine("the enum value of 6th day" + (int)Week.fri);
            Console.WriteLine("the enum value of 7th day" + (int)Week.sat);
        }
    }
}
