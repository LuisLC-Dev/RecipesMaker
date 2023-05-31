using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipes_Maker
{
    public partial class Make_EditRecipeFrm : Form
    {
        private Recipe recipe;
        private bool response;
        public Make_EditRecipeFrm(Recipe newRecipe)
        {
            InitializeComponent();
            this.recipe = newRecipe;
        }

        private void editIngredientsButton_Click(object sender, EventArgs e)
        {
            EditIngredientsFrm editIngredientsFrm = new EditIngredientsFrm();
            editIngredientsFrm.ShowDialog();
            if (editIngredientsFrm.GetResponse())
            {
                recipe.SetIngredients(editIngredientsFrm.GetIngredients());
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //falta validar que las tb no esten vacias y la lista de ingredientes tampoco
            if(tbRecipeName.Text != "" && tbDescription.Text != "" && tbInstructions.Text != "" && recipe.GetIngredients().Count() > 0)
            {
                this.response = true;
                this.recipe.SetRecipeName(tbRecipeName.Text);
                this.recipe.SetRecipeDescription(tbDescription.Text);
                this.recipe.SetRecipeInstructions(tbInstructions.Text);
            }
            else
            {
                MessageBox.Show("Por favor completa todos los campos");
            }
        }

        #region Setters

        #endregion

        #region Getters
        public Recipe GetRecipe()
        {
            return this.recipe;
        }

        public bool GetResponse()
        {
            return this.response;
        }
        #endregion
    }
}
