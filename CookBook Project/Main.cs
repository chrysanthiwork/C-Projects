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


recipe.PrintFullRecipe();

Console.ReadKey();


