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
        Console.WriteLine($"[{Name}] ({Servings}인분)");
        Console.WriteLine("재료:");

        foreach (Ingredient ingredient in Ingredients)
        {
            Console.WriteLine($"- {ingredient.Name}: {ingredient.Amount}{ingredient.Unit}");
        }
    }

    public RecipeCard ScaleRecipe(int newServings)
    {
        double scaleFactor = (double)newServings / Servings;

        Ingredient[] newIngrediets = new Ingredient[Ingredients.Length];

        for (int i = 0; i < Ingredients.Length; i++)
        {
            newIngrediets[i] = new Ingredient
            {
                Name = Ingredients[i].Name,
                Amount = Ingredients[i].Amount * scaleFactor,
                Unit = Ingredients[i].Unit
            };
        }

        return new RecipeCard(Name, newServings, newIngrediets);
    }
}