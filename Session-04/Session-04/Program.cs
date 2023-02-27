// See https://aka.ms/new-console-template for more information
using Session_04;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        //Exercise 1
        ExOne exOne = new ExOne();

        Console.WriteLine("Exercise 1 results: \n");
        Console.WriteLine(exOne.getGreeting());

        seperator();

        //Exercise 2

        ExTwo exTwo = new ExTwo();

        Console.WriteLine("Exercise 2 results: \n");

        Console.WriteLine("{0} + {1} = {2}", exTwo.getX(), exTwo.getY(), exTwo.getSum());
        if (exTwo.getY() != 0)
        {
            Console.WriteLine("{0} / {1} = {2}", exTwo.getX(), exTwo.getY(), exTwo.getDivision());
        }
        else { Console.WriteLine("Divisor is 0."); }
        

        seperator();


        //Exercise 3

        ExThree exThree = new ExThree();

        Console.WriteLine("Exercise 3 results: \n");
        Console.WriteLine("1st Calculation: {0}", exThree.firstCalc());
        Console.WriteLine("2nd Calculation: {0}", exThree.secondCalc());
        Console.WriteLine("3rd Calculation: {0}", exThree.thirdCalc());
        Console.WriteLine("4th Calculation: {0}", exThree.fourthCalc());
        Console.WriteLine("5th Calculation: {0}", exThree.fifthCalc());


        seperator();

        //Exercise 4

        ExFour exFour = new ExFour();


        Console.WriteLine("Exercise 4 results: \n");
        Console.WriteLine("You are {0} and you look younger than {1}.", exFour.getGender(), exFour.getAge());

        seperator();

        //Exercise 5
        ExFive exFive = new ExFive();


        Console.WriteLine("Exercise 5 results: \n");
        Console.WriteLine(exFive.getDates());

        seperator();


        //Exercise 6
        ExSix exSix = new ExSix();


        Console.WriteLine("Exercise 6 results: \n");
        Console.WriteLine(exSix.getDates());

        seperator();


       //Exercise 7

        ExSeven exSeven = new ExSeven();


        Console.WriteLine("Exercise 7 results: \n");
        Console.WriteLine(exSeven.getDegrees());

        seperator();

         Console.ReadLine();


    }



    public static void seperator()
    {
        Console.WriteLine("" +
        "\n================================================");
    }
}