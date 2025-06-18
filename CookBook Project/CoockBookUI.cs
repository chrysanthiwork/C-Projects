public class CookBookUI
{
   
    public static void PrintAvailableIngredients()
    {
        
        List<Ingredient> ingredients = new List<Ingredient>
    {
        new WheatFlour(),
        new CoconutFlour(),
        new Butter(),
        new Chocolate(),
        new Sugar(),
        new Cardamom(),
        new Cinnamon(),
        new CocoaPowder()
    };

        Console.WriteLine("Create a new cookie recipe! Available ingredients are:");
        foreach (var ingredient in ingredients)
        {
            Console.WriteLine($"{ingredient.ID}. {ingredient.Name}");
        }
    }

    public static void PrintAddIngredientMessage()
    {
        Console.WriteLine("Add an ingredient by its ID or type anything else if finished");
    }

    public static void NotSelectedAnyIngredientMessage()
    {
        Console.WriteLine("No ingredients have been selected. Recipe will not be saved.");
    }

    public static void AtLeastOneIngredientSelectedMessage()
    {
        Console.WriteLine("Recipe added:");
    }

    public static void SavedInFileMessage()
    {
        Console.WriteLine("Storing recipes in a text file.");
    }

    public static void PressAnyKeyToExitMessage()
    {
        Console.WriteLine("Press any key to exit");
    }
}
