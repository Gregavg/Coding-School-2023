// See https://aka.ms/new-console-template for more information
using Session_05;
using System.Numerics;

internal class Program {
    private static void Main(string[] args) {




        //Exercise 1    
        string inputOne = "Grigoris Avgenikos";

        ExOneReverse exOne = new ExOneReverse(inputOne);

        Console.WriteLine("Exercise 1 results:\n");
        Console.WriteLine(exOne.GetReversed());
        Seperator();



        //Exercise 2
        while (true) {
            Console.WriteLine("Type an integer for Exercise 2 or nothing to skip:");
            string? inputTwo = Console.ReadLine();

            if (!String.IsNullOrWhiteSpace(inputTwo) && int.TryParse(inputTwo, out int number)) {
                //int number = Convert.ToInt32(inputTwo);
                if (number <= 0) {
                    Console.WriteLine("Number must be greater than 0! Please try again!\n");
                    continue;
                }

                //SUM OR PROD?
                else {
                    ExTwoSumProd exTwo = new ExTwoSumProd(number);

                    while (true) {
                        Console.WriteLine("Type SUM for summary or PROD for product or nothing to skip:");
                        string? inputSumOrProd = Console.ReadLine();

                        if (String.IsNullOrWhiteSpace(inputSumOrProd)) {
                            Console.WriteLine("Skipping exercise 2... \n");
                            Seperator();
                            break;
                        } else if (inputSumOrProd.ToLower() == "sum") {
                            Console.WriteLine("\nExercise 2 results:");
                            Console.Write("Sum from 1 to {0} is ", number);
                            Console.WriteLine(exTwo.GetSum());
                            Seperator();
                            break;
                        } else if (inputSumOrProd.ToLower() == "prod") {
                            Console.WriteLine("\nExercise 2 results: ");
                            Console.Write("Product from 1 to {0} is ", number);

                            BigInteger bigNumbe = exTwo.GetProd();
                            Console.WriteLine(bigNumbe);
                            Seperator();
                            break;

                        } else {
                            Console.WriteLine("\nNumber must SUM or PROD! Please try again!");
                            continue;
                        }
                    }
                    break;
                }
            } else if (String.IsNullOrWhiteSpace(inputTwo)) {
                Console.WriteLine("Skipping exercise 2...");
                Seperator();
                break;
            } else {
                Console.WriteLine("Must be an integer! Please try again!\n");
                continue;
            }
        }


        //Exercise 3
        while (true) {
            Console.WriteLine("Type an integer for Exercise 3 or nothing to skip:");
            string? inputTwo = Console.ReadLine();

            if (!String.IsNullOrWhiteSpace(inputTwo) && int.TryParse(inputTwo, out int numberToPrime)) {

                if (numberToPrime <= 0) {
                    Console.WriteLine("Number must be greater than 0! Please try again!\n");
                    continue;
                } else {
                    ExThreePrimes exThree = new ExThreePrimes();
                    Console.WriteLine("\nExercise 3 results: \n");
                    Console.Write("Prime numbers from 1 to {0} are:{1}.\n", numberToPrime, exThree.GetPrimes(numberToPrime));
                    Seperator();
                    break;
                }

            } else if (String.IsNullOrWhiteSpace(inputTwo)) {
                Console.WriteLine("Skipping exercise 3...");
                Seperator();
                break;
            } else {
                Console.WriteLine("Must be an integer! Please try again!\n");
                continue;
            }
        }


        //Exercise 4

        int[] arrayOne = new int[] { 2, 4, 9, 12 };
        int[] arrayTwo = new int[] { 1, 3, 7, 10 };

        ExFourMulti exFour = new ExFourMulti();

        int[] arrayMulti = exFour.GetMulti(arrayOne, arrayTwo);

        Console.WriteLine("Exercise 4 array results: \n");

        foreach (int i in arrayMulti) {
            Console.Write(i + " ");

        }
        Console.WriteLine();
        Seperator();


        //Exercise 5

        int[] arrayForSort = new int[] { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };

        ExFiveSort exFive = new ExFiveSort();


        Console.WriteLine("Exercise 5 array results: \n");
        Console.Write("Array:\t [ ");
        foreach (int i in arrayForSort) {
            Console.Write(i + " ");

        }
        Console.Write("]\n\n");

        int[] arraySorted = exFive.Sort(arrayForSort);
        Console.Write("Sorted:\t [ ");
        foreach (int i in arraySorted) {
            Console.Write(i + " ");

        }
        Console.Write("] \n\n");

        Console.ReadLine();
    }

    public static void Seperator() {
        Console.WriteLine("" +
        "===========================================================================");
    }
}