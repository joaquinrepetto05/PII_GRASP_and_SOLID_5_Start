using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter 
    {
        public void PrintRecipe(IRecipeContent recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}