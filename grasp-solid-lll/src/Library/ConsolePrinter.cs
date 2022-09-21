using System;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter:ITipoDeImprimir
    {

        public void Print(Recipe recipe )
        {
            
            Console.WriteLine(recipe.GetTextToPrint());

        }
    }
}