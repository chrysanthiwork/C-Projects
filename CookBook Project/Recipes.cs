using System.Xml.Linq;

public class Recipes
{
    public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();


    private static readonly List<Ingredient> _ingredients = new List<Ingredient>
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

    public void PrintFullRecipe()
    {
        if (Ingredients.Any()) {
            Console.WriteLine("Recipe added:");
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine($"{ingredient.Name}: {ingredient.Instructions}");
            }
        }
        else
        {
            CookBookUI.NotSelectedAnyIngredientMessage();
        }
        
    }

    public static Ingredient FindIngredientById(int id)
    {
        return _ingredients.FirstOrDefault(ingredient => ingredient.ID == id);
    }

    public void AddIngredient(int id)
    {
        var ingredient = FindIngredientById(id);
        if (ingredient != null)
        {
            Ingredients.Add(ingredient);
        }
        else
        {
            Console.WriteLine("Ingredient not found.");
        }
    }


    public static void PrintAvailableIngredients()
    {
        Console.WriteLine("Available ingredients:");
        foreach (var ingredient in _ingredients)
        {
            Console.WriteLine($"ID: {ingredient.ID}, Name: {ingredient.Name}");
        }
    }

    public override string ToString()
    {
        // Προσαρμόστε ανάλογα με τα properties της συνταγής
        string result = $"Ingredients:\n";
        foreach (var ingredient in Ingredients)
        {
            result += $"- {ingredient.Name}: {ingredient.Instructions}\n";
        }
        return result;
    }

}
