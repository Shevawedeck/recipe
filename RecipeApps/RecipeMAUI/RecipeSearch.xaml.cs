using RecipeSystem;
using System.Data;

namespace RecipeMAUI;

public partial class RecipeSearch : ContentPage
{
	public RecipeSearch()
	{
		InitializeComponent();
	}
	private void SearchRecipes()
	{
		DataTable dt = Recipe.SearchRecipes(RecipeNameTxt.Text);
		RecipeLst.ItemsSource = dt.Rows;
	}
    private void SearchBtn_Clicked(object sender, EventArgs e)
    {
		SearchRecipes();
    }
}