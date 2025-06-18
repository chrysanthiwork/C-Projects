var Saved_Recipes = JSONHandler.JSONDeSerialization();
if (Saved_Recipes != null)
{
    Console.WriteLine("Existing Recipes are: ");
    int counter = 1;
    foreach (var saved_recipe in Saved_Recipes)
    {
        Console.WriteLine($"***** Recipe {counter} *****");
        counter++;

        foreach (var ingredient in saved_recipe.Ingredients)
        {
            Console.WriteLine($"- {ingredient.Name}: {ingredient.Instructions}");
        }

        Console.WriteLine(); // Κενή γραμμή για καλύτερο format
    }
}


CookBookUI.PrintAvailableIngredients();
CookBookUI.PrintAddIngredientMessage();
var recipe = new Recipes();
var input = Console.ReadLine();

while (ErrorHandling.WrongInputType(input))
{
    var id = int.Parse(input);
    if(id >= 1 && id <= 8)
    {
        recipe.AddIngredient(id);
        CookBookUI.PrintAddIngredientMessage();
    }
    else
    {
        break;
    }
        input = Console.ReadLine();
}

if (recipe != null)
{
    JSONHandler.JSONSerialization(recipe);
    recipe.PrintFullRecipe();
}


Console.ReadKey();


