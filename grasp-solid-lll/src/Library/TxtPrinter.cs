using System;
using System.Collections.Generic;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public class TxtPrinter:ITipoDeImprimir
    {
        public void Print(Recipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}