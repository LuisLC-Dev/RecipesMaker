using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_Maker
{
    internal class Ingredient
    {
        string name;

        public Ingredient(string name)
        {
            this.name = name;
        }

        public string GetIngredientName()
        {
            return name;
        }
    }
}
