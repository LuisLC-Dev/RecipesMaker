namespace Recipes_Maker
{
    public partial class MainMenuFrm : Form
    {
        List<Recipe> recipes = new List<Recipe>();
        public MainMenuFrm()
        {
            InitializeComponent();
        }

        private void makeRecipeButton_Click(object sender, EventArgs e)
        {
            Make_EditRecipeFrm make_EditRecipeFrm = new Make_EditRecipeFrm(new Recipe("", new List<Ingredient>(), new List<int>(), "", ""));
            make_EditRecipeFrm.ShowDialog();

            if (make_EditRecipeFrm.GetResponse())
            {
                this.recipes.Add(make_EditRecipeFrm.GetRecipe());
            }
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