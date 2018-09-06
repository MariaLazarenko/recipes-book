namespace RecipeBook
{
    partial class EditAddRecipeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAddRecipeForm));
            this.tbNameInput = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lbIngredients = new System.Windows.Forms.ListBox();
            this.lbRecipeIngredients = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbAmountInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbAmount = new System.Windows.Forms.ListBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.tbDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNameInput
            // 
            this.tbNameInput.Location = new System.Drawing.Point(188, 68);
            this.tbNameInput.Name = "tbNameInput";
            this.tbNameInput.Size = new System.Drawing.Size(158, 20);
            this.tbNameInput.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(336, 519);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 41);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Сохранить";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lbIngredients
            // 
            this.lbIngredients.FormattingEnabled = true;
            this.lbIngredients.Location = new System.Drawing.Point(194, 325);
            this.lbIngredients.Name = "lbIngredients";
            this.lbIngredients.Size = new System.Drawing.Size(130, 160);
            this.lbIngredients.TabIndex = 2;
            this.lbIngredients.SelectedIndexChanged += new System.EventHandler(this.lbIngredients_SelectedIndexChanged);
            // 
            // lbRecipeIngredients
            // 
            this.lbRecipeIngredients.FormattingEnabled = true;
            this.lbRecipeIngredients.Location = new System.Drawing.Point(446, 325);
            this.lbRecipeIngredients.Name = "lbRecipeIngredients";
            this.lbRecipeIngredients.Size = new System.Drawing.Size(101, 160);
            this.lbRecipeIngredients.TabIndex = 3;
            this.lbRecipeIngredients.SelectedIndexChanged += new System.EventHandler(this.lbRecipeIngredients_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbAmountInput
            // 
            this.tbAmountInput.Location = new System.Drawing.Point(336, 368);
            this.tbAmountInput.Name = "tbAmountInput";
            this.tbAmountInput.Size = new System.Drawing.Size(46, 20);
            this.tbAmountInput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "гр.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Доступные ингредиенты";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ингредиенты рецепта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Название блюда";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(46, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Создать ингредиент";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbAmount
            // 
            this.lbAmount.FormattingEnabled = true;
            this.lbAmount.Location = new System.Drawing.Point(544, 325);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(48, 160);
            this.lbAmount.TabIndex = 11;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(385, 68);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 21);
            this.cbCategory.TabIndex = 12;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(162, 134);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(477, 140);
            this.tbDescription.TabIndex = 13;
            this.tbDescription.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(159, 118);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(57, 13);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Описание";
            // 
            // EditAddRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(877, 618);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAmountInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbRecipeIngredients);
            this.Controls.Add(this.lbIngredients);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbNameInput);
            this.Name = "EditAddRecipeForm";
            this.Text = "EditRecipeForm";
            this.Load += new System.EventHandler(this.EditRecipeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNameInput;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox lbIngredients;
        private System.Windows.Forms.ListBox lbRecipeIngredients;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbAmountInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lbAmount;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.RichTextBox tbDescription;
        private System.Windows.Forms.Label lblDescription;
    }
}