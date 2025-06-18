using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

public static class JSONHandler
{
    public static void JSONSerialization(Recipes recipe)
    {
        if (recipe != null)
        {
            // Φόρτωσε ήδη υπάρχουσες συνταγές
            List<Recipes> existingRecipes = JSONDeSerialization();

            // Πρόσθεσε τη νέα συνταγή
            existingRecipes.Add(recipe);

            // Αποθήκευσε όλη τη λίστα πίσω στο αρχείο
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(existingRecipes, options);
            File.WriteAllText("recipes.json", jsonString);

            Console.WriteLine("Recipes successfully saved to recipes.json.");
        }
        else
        {
            Console.WriteLine("No JSON created because no recipes found!");
        }
    }

    public static List<Recipes> JSONDeSerialization()
    {
        if (File.Exists("recipes.json"))
        {
            string jsonString = File.ReadAllText("recipes.json");

            try
            {
                List<Recipes>? recipes = JsonSerializer.Deserialize<List<Recipes>>(jsonString);
                Console.WriteLine("Recipes successfully loaded from recipes.json.");
                return recipes ?? new List<Recipes>();
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Error reading recipes.json: {ex.Message}");
                return new List<Recipes>();
            }
        }
        else
        {
            Console.WriteLine("recipes.json file not found. Returning empty list.");
            return new List<Recipes>();
        }
    }
}
