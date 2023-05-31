namespace Recipes_Maker
{
    public partial class MainMenuFrm : Form
    {
        public MainMenuFrm()
        {
            InitializeComponent();
        }

        private void makeRecipeButton_Click(object sender, EventArgs e)
        {
            Make_EditRecipeFrm make_EditRecipeFrm = new Make_EditRecipeFrm();
            make_EditRecipeFrm.ShowDialog();
        }

        private void myRecipesButton_Click(object sender, EventArgs e)
        {
            RecipesList showRecipeFrm = new RecipesList();
            showRecipeFrm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}