using System;

struct RecipeCard
{
    public string Name;
    public int Servings;
    public Ingredient[] Ingredients;

    public RecipeCard(string name, int servings, Ingredient[] ingredients)
    {
        Name = name;
        Servings = servings;
        Ingredients = ingredients;
    }

    public void PrintRecipe()
    {
        ScaleRecipe(Servings);
    }

    public void ScaleRecipe(int newServings)
    {
        double scaleFactor = (double)newServings / Servings;


        Console.WriteLine($"[{Name}] ({newServings}인분)");
        Console.WriteLine("재료:");

        foreach (Ingredient ingredient in Ingredients)
        {
            Console.WriteLine($"- {ingredient.Name}: {ingredient.Amount*scaleFactor}{ingredient.Unit}");
        }
    }
}