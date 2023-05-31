﻿using System;
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
        private bool response;
        public EditIngredientsFrm()
        {
            InitializeComponent();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Add_EditIngredient add_EditIngredient = new Add_EditIngredient();
            add_EditIngredient.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Add_EditIngredient add_EditIngredient = new Add_EditIngredient();
            add_EditIngredient.ShowDialog();
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
