//author:BHSV
//date:4-2-21
using System;
//switch program along with enum
namespace Switch
{
    class Program
    {
        //declaring enum constants
        enum Num
        {
            one,
            three,
            five
        }
        static void Main(string[] args)
        {
            Num i = Num.three;
            switch (i)
            {

                case Num.one:
                    Console.WriteLine("case 1");
                    break;

                case Num.three:
                    Console.WriteLine("case 3");
                    break;

                case Num.five:
                    Console.WriteLine("case 5");
                    break;

                default:
                    Console.WriteLine("no match found");
                    break;
            }
        }
    }
}
