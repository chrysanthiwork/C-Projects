public abstract class Ingredient
{

    public abstract int ID { get; }
    public abstract string Name { get; }
    public abstract string Instructions { get; }

    
}

public class WheatFlour : Ingredient
{
    public override int ID => 1;
    public override string Name => "Wheat Flour";
    public override string Instructions => "Sieve. Add to other ingredients.";
}
public class CoconutFlour : Ingredient
{
    public override int ID => 2;
    public override string Name => "Coconut Flour";
    public override string Instructions => "Sieve. Add to other ingredients.";
}
public class Butter : Ingredient
{
    public override int ID => 3;
    public override string Name => "Butter";
    public override string Instructions => "Melt on low heat. Add to other ingredients.";
}

public class Chocolate : Ingredient
{
    public override int ID => 4;
    public override string Name => "Chocolate";
    public override string Instructions => "Melt in a water bath. Add to other ingredients.";
}

public class Sugar : Ingredient
{
    public override int ID => 5;
    public override string Name => "Sugar";
    public override string Instructions => "Add to other ingredients.";
}

public class Cardamom : Ingredient
{
    public override int ID => 6;
    public override string Name => "Cardamom";
    public override string Instructions => "Take half a teaspoon. Add to other ingredients.";

    public static Ingredient FindIngredientById(List<Ingredient> ingredients, int id)
    {
        return ingredients.FirstOrDefault(ingredient => ingredient.ID == id);
    }

}

public class Cinnamon : Ingredient
{
    public override int ID => 7;
    public override string Name => "Cinnamon";
    public override string Instructions => "Take half a teaspoon. Add to other ingredients.";
}

public class CocoaPowder : Ingredient
{
    public override int ID => 8;
    public override string Name => "Cocoa Powder";
    public override string Instructions => "Add to other ingredients.";
}
