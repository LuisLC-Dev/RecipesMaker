using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_Maker
{
    public class Category
    {
        private string name;
        private List<Ingredient> ingredients;

        //Constructor
        public Category(string name, List<Ingredient> ingredients)
        {
            this.name = name;
            this.ingredients = ingredients;
        }

        #region Getters
        public string GetName()
        {
            return name;
        }

        public List<Ingredient> GetIngredients()
        {
            return ingredients;
        }
        #endregion

        #region Setters
        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetIngredients(List<Ingredient> ingredients)
        {
            this.ingredients = ingredients;
        }
        #endregion

        public void AddIngredient(Ingredient ingredient)
        {
            this.ingredients.Add(ingredient);
        }
    }
}
