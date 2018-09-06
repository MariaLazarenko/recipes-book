using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeBook
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        recipeDb db = new recipeDb();
        string selectedRecipeName = ""; 

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (var db = new recipeDb())
            {
                var recipes = db.Recipes
                    .Where(r => r.CategoryId == 2)
                    .ToList();
                lbRecipesList.DataSource = recipes;
                lbRecipesList.DisplayMember = "Name";
            }
            //List<Recipe> recipes = db.Recipes
            //      .Where(r => r.CategoryId == 1)
            //      .ToList(); 

            //var db = new recipes_dbEntities();

            //Recipe recipe = new Recipe
            //{
            //    Name = "Грибной суп",
            //    CategoryId = 1
            //};

            //db.Recipes.Add(recipe);
            //db.SaveChanges();
        }

        private void btnSalads_Click(object sender, EventArgs e)
        {
            using (var db = new recipeDb())
            {
                var recipes = db.Recipes
                    .Where(r => r.CategoryId == 2)
                    .ToList();
                lbRecipesList.DataSource = recipes;
                lbRecipesList.DisplayMember = "Name";
            }
            
        }

        private void btnSoups_Click(object sender, EventArgs e)
        {
            using (var db = new recipeDb())
            {
                List<Recipe> recipes = db.Recipes
                    .Where(r => r.CategoryId == 1)
                    .ToList();
                lbRecipesList.DataSource = recipes;
                lbRecipesList.DisplayMember = "Name";
            }
        }

        private void lbRecipesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedRecipeName = ((Recipe)lbRecipesList.SelectedItem).Name;

            lblRecipeName.Text = selectedRecipeName;
            lblRecipeComposition.Text = "Состав:\n\n";
            using (var db = new recipeDb())
            {
                var recipeComposition = (from i in db.Ingredients
                                         join c in db.Compositions
                                         on i.Id equals c.IngredientId
                                         join r in db.Recipes
                                         on c.RecipeId equals r.Id
                                         where r.Name == selectedRecipeName
                                         select new
                                         {
                                             ingName = i.Name,
                                             ingAmount = c.Amount,
                                             ingProteins = i.Proteins,
                                             ingFats = i.Fats,
                                             ingCarbs = i.Carbs,
                                             recepieDescription = r.Description
                                         })
                   .ToList();
                decimal sumProteins = 0,
                      sumFats = 0,
                      sumCarbs = 0;
                for (int i = 0; i < recipeComposition.Count; i++)
                {
                    lblRecipeComposition.Text += recipeComposition[i].ingName + " - " + recipeComposition[i].ingAmount + " гр.\n";
                    sumProteins += recipeComposition[i].ingAmount / 100 * recipeComposition[i].ingProteins;
                    sumFats += recipeComposition[i].ingAmount / 100 * recipeComposition[i].ingFats;
                    sumCarbs += recipeComposition[i].ingAmount / 100 * recipeComposition[i].ingCarbs;
                }
                lblRecipeComposition.Text += "\n\nПищевая ценность:\n\n";
                lblRecipeComposition.Text += "Белки: " + sumProteins + "\n";
                lblRecipeComposition.Text += "Жиры: " + sumFats + "\n";
                lblRecipeComposition.Text += "Углеводы: " + sumCarbs + "\n";

                var recipe = db.Recipes
                    .Where(r => r.Name == selectedRecipeName)
                    .FirstOrDefault();

                lblDescription.Text = "Описание:\n\n" + recipe.Description;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {                   
            EditAddRecipeForm editRecipeForm = new EditAddRecipeForm(selectedRecipeName);
            editRecipeForm.Show();    
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            EditAddRecipeForm editRecipeForm = new EditAddRecipeForm();
            editRecipeForm.Show();
        }
    }
}
