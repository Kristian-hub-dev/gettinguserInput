using gettinguserInput;
using System;
       
Console.WriteLine("Select the operation");
Console.WriteLine("1 Press 1 for Addition");
Console.WriteLine("2 Press 2 for Subtraction");
Console.WriteLine("3 Press 3 for Multiplication");
Console.WriteLine("4 Press 4 for Division");


Console.WriteLine("Enter your choice:");
int choice = int.Parse(Console.ReadLine());

string FNumber, sNumber;


Console.WriteLine("Enter the first number:");
FNumber = Console.ReadLine();
int fNum = Int32.Parse(FNumber);

Console.WriteLine("Enter the second number:");
sNumber = Console.ReadLine();
int sNum = Int32.Parse(sNumber);

CalculatorBase myCalculator = new CalculatorBase(fNum, sNum);

        switch (choice)
        {
            case 1:
                Console.WriteLine($"The sum of {fNum} and {sNum} is {myCalculator.GetSum()}");
                break;
            case 2:
                Console.WriteLine($"The difference of {fNum} and {sNum} is {myCalculator.GetDifference()}");
                break;
            case 3:
                Console.WriteLine($"The product of {fNum} and {sNum} is {myCalculator.GetProduct()}");
                break;
            case 4:
                Console.WriteLine($"The quotient of {fNum} divided by {sNum} is {myCalculator.GetQuotient()}");
                break;
            default:
                Console.WriteLine("Invalid choice! Please choose your choice (1-4).");
                break;
        }
    

