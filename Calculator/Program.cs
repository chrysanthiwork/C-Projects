Console.WriteLine("Hello!");
Console.WriteLine("Input the first number:");

string userFirstNumber = Console.ReadLine();
int firstNumber = int.Parse(userFirstNumber);

Console.WriteLine("Input the second number:");
string userSecondNumber = Console.ReadLine();
int secondNumber = int.Parse(userSecondNumber);

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");

string userCommandChoice = Console.ReadLine();
calculateResults(firstNumber, secondNumber, userCommandChoice);

Console.WriteLine("Press any key to close");
Console.ReadKey();

void calculateResults(int firstNumber, int secondNumber, string command) { 
    if(command == "A" || command == "a")
    {
        Console.WriteLine("The addition of the given numbers gives the result of: " + (firstNumber + secondNumber));
    }
    else if (command == "S" || command == "s")
    {
        Console.WriteLine("The substraction of the given numbers gives the result of: " + (firstNumber - secondNumber));
    }
    else if (command == "M" || command == "m")
    {
        Console.WriteLine("The multiplication of the given numbers gives the result of: " + (firstNumber * secondNumber));
    }
    else
    {
        Console.WriteLine("Invalid option");
    }
}