using System;

RecipeCard tomatoPasta = new RecipeCard(
    "토마토 파스타",
    2,
    new Ingredient[]
    {
        new Ingredient("스파게티면", 200, "g"),
        new Ingredient("토마토소스", 150, "ml"),
        new Ingredient("양파", 1, "개"),
        new Ingredient("마늘", 3, "쪽"),
    }
);

Console.WriteLine("=== 원본 레시피 ===");
tomatoPasta.PrintRecipe();

Console.WriteLine();
Console.WriteLine("=== 4인분으로 변환 ===");

RecipeCard tomatoPasta4 = tomatoPasta.ScaleRecipe(4);
tomatoPasta4.PrintRecipe();
