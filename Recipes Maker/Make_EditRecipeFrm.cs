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
        public Make_EditRecipeFrm()
        {
            InitializeComponent();
        }

        private void editIngredientsButton_Click(object sender, EventArgs e)
        {
            EditIngredientsFrm frm = new EditIngredientsFrm();
            frm.ShowDialog();
        }
    }
}
