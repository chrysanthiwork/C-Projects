Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries");
Console.WriteLine("Enter a number: ");

var dice = new Dice();
while(dice.TriesCounter > 0 && dice.BooleanChecker == false)
{
    var input = Console.ReadLine();
    dice.Guess(input);
}

Console.WriteLine(" ");
Console.WriteLine("Thank you for playing our game. :)");
Console.WriteLine("Press any key to exit.");
Console.ReadKey();

public static class NumberValidity {

    public static bool ValidationCheck(string input)
    {
        return int.TryParse(input, out int number) && number >= 1 && number <= 6; ;
    }

}
public static class GameUI
{
    public static void ShowStartMessage()
    {
        Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries");
        Console.WriteLine("Enter a number: ");
    }

    public static void ShowErrorNoNumber()
    {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
    }

    public static void ShowWrongGuess(int triesLeft)
    {
        Console.WriteLine("Wrong number.");
        Console.WriteLine($"You have {triesLeft} chances left");
    }

    public static void ShowWin()
    {
        Console.WriteLine("You win!");
    }

    public static void ShowLose()
    {
        Console.WriteLine("You lose!");
    }
}

class Dice {

    private int _user_guess;

    public int TriesCounter { get; private set; }

    public bool BooleanChecker { get; private set; }
    public Dice()
    {
        TriesCounter = 3;
    }

    public void Guess(string given_number)
    {
        // Υποθέτουμε ότι ValidationCheck είναι στατική μέθοδος
        if (NumberValidity.ValidationCheck(given_number))
        {
            _user_guess = int.Parse(given_number);

            Random random = new Random();
            int randomNumber = random.Next(1, 7); // 1 έως 6

            if (_user_guess == randomNumber)
            {
                GameUI.ShowWin();
                BooleanChecker = true;
            }
            else
            {
                TriesCounter--;

                GameUI.ShowWrongGuess(TriesCounter);

                if (TriesCounter == 0)
                {
                    GameUI.ShowLose();
                    return;
                }

                GameUI.ShowStartMessage();
            }
        }
        else
        {
            GameUI.ShowErrorNoNumber();
        }
    }



}


