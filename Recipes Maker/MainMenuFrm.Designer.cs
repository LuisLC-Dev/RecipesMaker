namespace Recipes_Maker
{
    partial class MainMenuFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuFrm));
            this.makeRecipeButton = new System.Windows.Forms.Button();
            this.myRecipesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // makeRecipeButton
            // 
            this.makeRecipeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.makeRecipeButton.FlatAppearance.BorderSize = 0;
            this.makeRecipeButton.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.makeRecipeButton.Image = ((System.Drawing.Image)(resources.GetObject("makeRecipeButton.Image")));
            this.makeRecipeButton.Location = new System.Drawing.Point(121, 201);
            this.makeRecipeButton.Name = "makeRecipeButton";
            this.makeRecipeButton.Size = new System.Drawing.Size(276, 83);
            this.makeRecipeButton.TabIndex = 0;
            this.makeRecipeButton.Text = "Hacer una receta";
            this.makeRecipeButton.UseVisualStyleBackColor = true;
            this.makeRecipeButton.Click += new System.EventHandler(this.makeRecipeButton_Click);
            // 
            // myRecipesButton
            // 
            this.myRecipesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.myRecipesButton.FlatAppearance.BorderSize = 0;
            this.myRecipesButton.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myRecipesButton.Image = ((System.Drawing.Image)(resources.GetObject("myRecipesButton.Image")));
            this.myRecipesButton.Location = new System.Drawing.Point(121, 352);
            this.myRecipesButton.Name = "myRecipesButton";
            this.myRecipesButton.Size = new System.Drawing.Size(276, 83);
            this.myRecipesButton.TabIndex = 1;
            this.myRecipesButton.Text = "Ver mis recetas";
            this.myRecipesButton.UseVisualStyleBackColor = true;
            this.myRecipesButton.Click += new System.EventHandler(this.myRecipesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(121, 504);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(276, 83);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Salir";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(121, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bienvenido a Recipe Maker";
            // 
            // MainMenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(513, 772);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.myRecipesButton);
            this.Controls.Add(this.makeRecipeButton);
            this.Name = "MainMenuFrm";
            this.Text = "Recipes Maker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button makeRecipeButton;
        private Button myRecipesButton;
        private Button exitButton;
        private Label label1;
    }
}