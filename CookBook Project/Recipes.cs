public class Recipes
{
    private List<Ingredient> ingredients = new List<Ingredient>();

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
        if (ingredients.Any()) {
            Console.WriteLine("Recipe added:");
            foreach (var ingredient in ingredients)
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
            ingredients.Add(ingredient);
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
}
