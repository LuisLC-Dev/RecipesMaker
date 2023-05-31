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
        private List<int> quantities = new List<int>();
        private List<Ingredient> ingredients = new List<Ingredient>();
        private bool response;
        public EditIngredientsFrm()
        {
            InitializeComponent();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Add_EditIngredient add_EditIngredient = new Add_EditIngredient();
            add_EditIngredient.SetIngredient(ingredients[dgIngredients.CurrentRow.Index]);
            add_EditIngredient.SetQuantity(quantities[dgIngredients.CurrentRow.Index]);
            add_EditIngredient.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Add_EditIngredient add_EditIngredient = new Add_EditIngredient();
            add_EditIngredient.ShowDialog();
            if (add_EditIngredient.GetResponse())
            {
                ingredients.Add(add_EditIngredient.GetIngredient());
                quantities.Add(add_EditIngredient.GetQuantity());
            }
            DataGridViewCell template = new DataGridViewTextBoxCell();
            dgIngredients.Columns.Clear();
            DataGridViewColumn quantitiesColumn = new DataGridViewColumn();
            quantitiesColumn.Name = "quantity";
            quantitiesColumn.HeaderText = "Cantidad";
            quantitiesColumn.CellTemplate = template;
            dgIngredients.Columns.Add(quantitiesColumn);
            DataGridViewColumn ingredientsColumn = new DataGridViewColumn();
            ingredientsColumn.Name = "ingredient";
            ingredientsColumn.HeaderText = "Ingrediente";
            ingredientsColumn.CellTemplate = template;
            dgIngredients.Columns.Add(ingredientsColumn);
            for(int i = 0; i < ingredients.Count(); i++)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgIngredients);
                r.Cells[0].Value = quantities[i].ToString();
                r.Cells[1].Value = ingredients[i].GetIngredientName();
                dgIngredients.Rows.Add(r);
            }
        }

        #region setters
        public void SetIngredients(List<Ingredient> ingredients)
        {
            this.ingredients = ingredients;
        }
        #endregion

        #region getters
        public List<Ingredient> GetIngredients()
        {
            return ingredients;
        }

        public bool GetResponse()
        {
            return response;
        }
        #endregion

        private void cancelButton_Click(object sender, EventArgs e)
        {
            response = false;
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(ingredients.Count > 0)
            {
                response = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor agrega por lo menos un ingrediente");
            }
        }
    }
}
