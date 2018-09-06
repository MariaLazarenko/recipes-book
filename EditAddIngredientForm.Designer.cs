namespace RecipeBook
{
    partial class EditAddIngredientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAddIngredientForm));
            this.tbNameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFatsInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCalloriesInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbProteinsInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCarbsInput = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNameInput
            // 
            this.tbNameInput.Location = new System.Drawing.Point(106, 53);
            this.tbNameInput.Name = "tbNameInput";
            this.tbNameInput.Size = new System.Drawing.Size(168, 20);
            this.tbNameInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Жиры / 100 гр.";
            // 
            // tbFatsInput
            // 
            this.tbFatsInput.Location = new System.Drawing.Point(106, 227);
            this.tbFatsInput.Name = "tbFatsInput";
            this.tbFatsInput.Size = new System.Drawing.Size(168, 20);
            this.tbFatsInput.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Белки / 100 гр.";
            // 
            // tbCalloriesInput
            // 
            this.tbCalloriesInput.Location = new System.Drawing.Point(106, 120);
            this.tbCalloriesInput.Name = "tbCalloriesInput";
            this.tbCalloriesInput.Size = new System.Drawing.Size(168, 20);
            this.tbCalloriesInput.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ккал / 100 гр";
            // 
            // tbProteinsInput
            // 
            this.tbProteinsInput.Location = new System.Drawing.Point(106, 171);
            this.tbProteinsInput.Name = "tbProteinsInput";
            this.tbProteinsInput.Size = new System.Drawing.Size(168, 20);
            this.tbProteinsInput.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Углеводы / 100 гр.";
            // 
            // tbCarbsInput
            // 
            this.tbCarbsInput.Location = new System.Drawing.Point(106, 277);
            this.tbCarbsInput.Name = "tbCarbsInput";
            this.tbCarbsInput.Size = new System.Drawing.Size(168, 20);
            this.tbCarbsInput.TabIndex = 8;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(148, 326);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Сохранить";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // EditAddIngredientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(388, 375);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCarbsInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbProteinsInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCalloriesInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFatsInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNameInput);
            this.Name = "EditAddIngredientForm";
            this.Text = "EditAddIngredientForm";
            this.Load += new System.EventHandler(this.EditAddIngredientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFatsInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCalloriesInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbProteinsInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCarbsInput;
        private System.Windows.Forms.Button btnSubmit;
    }
}