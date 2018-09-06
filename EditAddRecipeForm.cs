using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeBook
{
    public partial class EditAddRecipeForm : Form
    {
        public string SelectedRecipeName { set; get; }
        public string FormType { set; get; }
        string selectedIngredient = "";
        string selectedRecipeIngredient = "";

        public EditAddRecipeForm(string selectedRecipeName)
        {
            InitializeComponent();
            FormType = "Edit";
            SelectedRecipeName = selectedRecipeName;
        }

        public EditAddRecipeForm()
        {
            InitializeComponent();
            FormType = "Add";
        }

        private void EditRecipeForm_Load(object sender, EventArgs e)
        {

            using (var db = new recipeDb())
            {
                List<Ingredient> availableIngredients = db.Ingredients.ToList();
                foreach (Ingredient ingredient in availableIngredients)
                {
                    lbIngredients.Items.Add(ingredient.Name);
                }
                var categories = db.Categories.ToList();
                cbCategory.DataSource = categories;
                cbCategory.DisplayMember = "Name";
                switch (FormType)
                {              
                    case "Add":
                        tbNameInput.Text = "";
                        Text = "Добавить новый рецепт";
                        break;
                    case "Edit":
                        Text = "Редактировать " + SelectedRecipeName;
                        tbNameInput.Text = SelectedRecipeName;
                        var recipeComposition = (from i in db.Ingredients
                                           join c in db.Compositions
                                           on i.Id equals c.IngredientId
                                           join r in db.Recipes
                                           on c.RecipeId equals r.Id
                                           where r.Name == SelectedRecipeName
                                           select new { ingName = i.Name,
                                                        ingAmount = c.Amount
                                            })
                                           .ToList();
                        for (int i = 0; i < recipeComposition.Count; i++)
                        {
                            lbRecipeIngredients.Items.Add(recipeComposition[i].ingName);
                            lbAmount.Items.Add(recipeComposition[i].ingAmount);
                        }
                        var recipe = db.Recipes
                            .Where(r => r.Name == SelectedRecipeName)
                            .FirstOrDefault();
                        tbDescription.Text = recipe.Description;
                        break;
                }                
                
            }            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (var db = new recipeDb())
            {
                switch (FormType)
                {
                    case "Add":

                        db.Recipes.Add(new Recipe
                        {
                            Name = tbNameInput.Text,
                            CategoryId = ((Category)cbCategory.SelectedItem).Id,
                            Description = tbDescription.Text
                        });
                        db.SaveChanges();
                        
                        var recipe = db.Recipes
                            .Where(r => r.Name == tbNameInput.Text)
                            .FirstOrDefault();

                        for (int i = 0; i < lbRecipeIngredients.Items.Count; i++)
                        {
                            string ingName = lbRecipeIngredients.Items[i].ToString();
                            int ingAmount = Convert.ToInt32(lbAmount.Items[i]);
                            int recipeId = recipe.Id;
                            Ingredient ingredient = db.Ingredients
                                .Where(ing => ing.Name == ingName)
                                .FirstOrDefault();
                            int ingId = ingredient.Id;
                            db.Compositions.Add(new Composition
                            {
                                IngredientId = ingId,
                                Amount = ingAmount,
                                RecipeId = recipeId
                            });
                            db.SaveChanges();
                        }
                        break;
                    case "Edit":
                        Recipe recipeToEdit = db.Recipes
                            .Where(r => r.Name == SelectedRecipeName)
                            .FirstOrDefault();
                        recipeToEdit.Name = tbNameInput.Text;
                        recipeToEdit.Description = tbDescription.Text;
                        db.SaveChanges();

                        var recipe2 = db.Recipes
                            .Where(r => r.Name == tbNameInput.Text)
                            .FirstOrDefault();

                        for (int i = 0; i < lbRecipeIngredients.Items.Count; i++)
                        {
                            string ingName = lbRecipeIngredients.Items[i].ToString();
                            int ingAmount = Convert.ToInt32(lbAmount.Items[i]);
                            int recipeId = recipe2.Id;
                            Ingredient ingredient = db.Ingredients
                                .Where(ing => ing.Name == ingName)
                                .FirstOrDefault();
                            int ingId = ingredient.Id;
                            db.Compositions.Add(new Composition
                            {
                                IngredientId = ingId,
                                Amount = ingAmount,
                                RecipeId = recipeId
                            });
                            db.SaveChanges();
                        }

                        break;
                }
            } 
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditAddIngredientForm addIngredientForm = new EditAddIngredientForm(lbIngredients);
            addIngredientForm.Show();
        }

        private void lbIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIngredient = lbIngredients.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            lbRecipeIngredients.Items.Add(selectedIngredient);
            lbAmount.Items.Add(tbAmountInput.Text);
        }

        private void lbRecipeIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAmount.SelectedIndex = lbRecipeIngredients.SelectedIndex;
        }
    }
}
