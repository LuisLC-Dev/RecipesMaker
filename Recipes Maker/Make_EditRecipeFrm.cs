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
        private Recipe Recipe;
        private bool response;
        public Make_EditRecipeFrm(Recipe newRecipe)
        {
            InitializeComponent();
            this.Recipe = newRecipe;
        }

        private void editIngredientsButton_Click(object sender, EventArgs e)
        {
            EditIngredientsFrm editIngredientsFrm = new EditIngredientsFrm();
            editIngredientsFrm.ShowDialog();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //falta validar que las tb no esten vacias
            this.response = true;
            this.Recipe.SetRecipeName(tbRecipeName.Text);
            this.Recipe.SetRecipeDescription(tbDescription.Text);
            this.Recipe.SetRecipeInstructions(tbInstructions.Text);
        }

        #region Setters

        #endregion

        #region Getters
        public Recipe GetRecipe()
        {
            return this.Recipe;
        }

        public bool GetResponse()
        {
            return this.response;
        }
        #endregion
    }
}
