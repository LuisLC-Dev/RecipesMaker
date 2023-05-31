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
    public partial class Add_EditIngredient : Form
    {
        private Ingredient ingredient;
        private int quantity;
        private bool response;
        public Add_EditIngredient()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.response = false;
            this.Close();
        }

        private void accetpButton_Click(object sender, EventArgs e)
        {
            if(cbIngredient.Text != null && nupQuantity.Value > 0)
            {
                this.response = true;
                this.ingredient = new Ingredient(cbIngredient.Text);
                this.quantity = (int)nupQuantity.Value;
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor llena todos los campos");
            }
        }

        #region Setters
        public void SetIngredient(Ingredient ingredient)
        {
            this.ingredient = ingredient;
        }
        public void SetQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        #endregion

        #region Getters
        public bool GetResponse()
        {
            return this.response;
        }

        public Ingredient GetIngredient()
        {
            return this.ingredient;
        }

        public int GetQuantity()
        {
            return this.quantity;
        }
        #endregion
    }
}
