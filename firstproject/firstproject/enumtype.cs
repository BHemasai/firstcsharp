// C# program to illustrate the
// Enum.GetTypeCode() Method
using System;



class G
{

    enum Color { Blue, Black };



    // Main Method
    public static void Main(String[] args)
    {
        Color c1 = Color.Blue;
        Console.Write("TypeCode of Enum Constant " + c1 + " : ");



        // Using the GetTypeCode() Method
        Console.WriteLine(c1.GetTypeCode());



        Color c2 = Color.Black;
        Console.Write("TypeCode of Enum Constant " + c2 + " : ");



        // Using the GetTypeCode Method
        Console.WriteLine(c2.GetTypeCode());
    }
}