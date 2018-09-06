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
    public partial class EditAddIngredientForm : Form
    {
        public string FormType { set; get; }
        public ListBox IngredientsListBox { set; get; }
        public EditAddIngredientForm(ListBox ingredientsListBox)
        {
            InitializeComponent();
            FormType = "Add";
            IngredientsListBox = ingredientsListBox;
        }
        public EditAddIngredientForm(string selectedIngredientName)
        {
            InitializeComponent();
            FormType = "Edit";
        }

        private void EditAddIngredientForm_Load(object sender, EventArgs e)
        {
            switch(FormType)
            {
                case "Add":
                    Text = "Создать ингредиент";
                    break;
                case "Edit":
                    Text = "Редактировать ингредиент";
                    break;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (var db = new recipeDb())
            {
                Ingredient ingredient = new Ingredient
                {
                    Name = tbNameInput.Text,
                    Calories = Convert.ToDecimal(tbCalloriesInput.Text),
                    Proteins = Convert.ToDecimal(tbProteinsInput.Text),
                    Fats = Convert.ToDecimal(tbFatsInput.Text),
                    Carbs = Convert.ToDecimal(tbCarbsInput.Text)
                };
                db.Ingredients.Add(ingredient);
                db.SaveChanges();
                IngredientsListBox.Items.Add(ingredient.Name);
            }            
            Close();
        }
    }
}
