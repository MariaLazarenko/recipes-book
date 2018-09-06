namespace RecipeBook
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.recipes_dbDataSet = new RecipeBook.recipes_dbDataSet();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new RecipeBook.recipes_dbDataSetTableAdapters.CategoryTableAdapter();
            this.btnSalads = new System.Windows.Forms.Button();
            this.btnSoups = new System.Windows.Forms.Button();
            this.lbRecipesList = new System.Windows.Forms.ListBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.lblRecipeComposition = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recipes_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // recipes_dbDataSet
            // 
            this.recipes_dbDataSet.DataSetName = "recipes_dbDataSet";
            this.recipes_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.recipes_dbDataSet;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // btnSalads
            // 
            this.btnSalads.Location = new System.Drawing.Point(61, 63);
            this.btnSalads.Name = "btnSalads";
            this.btnSalads.Size = new System.Drawing.Size(75, 23);
            this.btnSalads.TabIndex = 0;
            this.btnSalads.Text = "Салаты";
            this.btnSalads.UseVisualStyleBackColor = true;
            this.btnSalads.Click += new System.EventHandler(this.btnSalads_Click);
            // 
            // btnSoups
            // 
            this.btnSoups.Location = new System.Drawing.Point(61, 119);
            this.btnSoups.Name = "btnSoups";
            this.btnSoups.Size = new System.Drawing.Size(75, 23);
            this.btnSoups.TabIndex = 1;
            this.btnSoups.Text = "Супы";
            this.btnSoups.UseVisualStyleBackColor = true;
            this.btnSoups.Click += new System.EventHandler(this.btnSoups_Click);
            // 
            // lbRecipesList
            // 
            this.lbRecipesList.FormattingEnabled = true;
            this.lbRecipesList.Location = new System.Drawing.Point(251, 63);
            this.lbRecipesList.Name = "lbRecipesList";
            this.lbRecipesList.Size = new System.Drawing.Size(211, 212);
            this.lbRecipesList.TabIndex = 2;
            this.lbRecipesList.SelectedIndexChanged += new System.EventHandler(this.lbRecipesList_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(293, 294);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(107, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(293, 333);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(107, 23);
            this.btnAddRecipe.TabIndex = 5;
            this.btnAddRecipe.Text = "Добавить";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipeName.Location = new System.Drawing.Point(576, 63);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(66, 24);
            this.lblRecipeName.TabIndex = 6;
            this.lblRecipeName.Text = "label1";
            // 
            // lblRecipeComposition
            // 
            this.lblRecipeComposition.AutoSize = true;
            this.lblRecipeComposition.Location = new System.Drawing.Point(577, 100);
            this.lblRecipeComposition.Name = "lblRecipeComposition";
            this.lblRecipeComposition.Size = new System.Drawing.Size(144, 13);
            this.lblRecipeComposition.TabIndex = 8;
            this.lblRecipeComposition.Text = "Состав, пищевая ценность";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(769, 100);
            this.lblDescription.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Description";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1152, 460);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblRecipeComposition);
            this.Controls.Add(this.lblRecipeName);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lbRecipesList);
            this.Controls.Add(this.btnSoups);
            this.Controls.Add(this.btnSalads);
            this.Name = "MainForm";
            this.Text = "Книга рецептов";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recipes_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private recipes_dbDataSet recipes_dbDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private recipes_dbDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.Button btnSalads;
        private System.Windows.Forms.Button btnSoups;
        private System.Windows.Forms.ListBox lbRecipesList;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.Label lblRecipeName;
        private System.Windows.Forms.Label lblRecipeComposition;
        private System.Windows.Forms.Label lblDescription;
    }
}

