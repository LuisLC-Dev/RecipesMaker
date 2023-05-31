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
    public partial class EditIngredientsFrm : Form
    {
        private List<Ingredient> ingredients = new List<Ingredient>();
        public EditIngredientsFrm()
        {
            InitializeComponent();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Add_EditIngredient add_EditIngredient = new Add_EditIngredient();
            add_EditIngredient.ShowDialog();
        }

        #region setters
        #endregion

        #region getters
        #endregion
    }
}
