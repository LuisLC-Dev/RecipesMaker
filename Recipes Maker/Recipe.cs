using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_Maker
{
    internal class Recipe
    {
        private string recipeName;
        private string recipeDescription;
        private List<Ingredient> ingredients;
        private List<int> quantities;
        private string recipeInstructions;

        public Recipe(string recipeName, List<Ingredient> ingredients, List<int> quantities, string recipeDescription, string recipeInstructions)
        {
            this.recipeName = recipeName;
            this.recipeDescription = recipeDescription;
            this.ingredients = ingredients;
            this.quantities = quantities;
            this.recipeInstructions = recipeInstructions;
        }

        #region Getters
        public string GetRecipeName()
        {
            return recipeName;
        }
        
        public string GetRecipeDescription()
        {
            return recipeDescription;
        }

        public List<Ingredient> GetIngredients()
        {
            return ingredients;
        }

        public List<int> GetQuantities()
        {
            return quantities;
        }

        public string GetRecipeInstrucrions()
        {
            return recipeInstructions;
        }
        #endregion

        #region Setters
        public void SetRecipeName(string name)
        {
            this.recipeName = name;
        }

        public void SetRecipeDescription(string recipeDescription)
        {
            this.recipeDescription = recipeDescription;
        }

        public void SetIngredients(List<Ingredient> ingredients)
        {
            this.ingredients = ingredients;
        }

        public void SetQuantities(List<int> quantities)
        {
            this.quantities = quantities;
        }

        public void SetRecipeInstructions(string recipeInstrucrions)
        {
            this.recipeInstructions = recipeInstrucrions;
        }
        #endregion

        public void AddIngredient(int quantity, Ingredient ingredient)
        {
            this.quantities.Add(quantity);
            this.ingredients.Add(ingredient);
        }

        public void DeleteIngredient(Ingredient ingredient)
        {
            int index = ingredients.IndexOf(ingredient);
            this.ingredients.RemoveAt(index);
            this.quantities.RemoveAt(index);
        }
    }
}
