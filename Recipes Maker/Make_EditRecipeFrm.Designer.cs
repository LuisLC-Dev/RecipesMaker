namespace Recipes_Maker
{
    partial class Make_EditRecipeFrm
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
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tbRecipeName = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIngredients = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbInstructions = new System.Windows.Forms.TextBox();
            this.editIngredientsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(494, 428);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(575, 428);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // tbRecipeName
            // 
            this.tbRecipeName.Location = new System.Drawing.Point(178, 81);
            this.tbRecipeName.Name = "tbRecipeName";
            this.tbRecipeName.Size = new System.Drawing.Size(472, 23);
            this.tbRecipeName.TabIndex = 2;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(178, 120);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(472, 69);
            this.tbDescription.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de la receta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripción:";
            // 
            // tbIngredients
            // 
            this.tbIngredients.Location = new System.Drawing.Point(178, 198);
            this.tbIngredients.Multiline = true;
            this.tbIngredients.Name = "tbIngredients";
            this.tbIngredients.ReadOnly = true;
            this.tbIngredients.Size = new System.Drawing.Size(472, 78);
            this.tbIngredients.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ingredientes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Instrucciones:";
            // 
            // tbInstructions
            // 
            this.tbInstructions.Location = new System.Drawing.Point(178, 311);
            this.tbInstructions.Multiline = true;
            this.tbInstructions.Name = "tbInstructions";
            this.tbInstructions.Size = new System.Drawing.Size(472, 102);
            this.tbInstructions.TabIndex = 9;
            // 
            // editIngredientsButton
            // 
            this.editIngredientsButton.Location = new System.Drawing.Point(575, 282);
            this.editIngredientsButton.Name = "editIngredientsButton";
            this.editIngredientsButton.Size = new System.Drawing.Size(75, 23);
            this.editIngredientsButton.TabIndex = 11;
            this.editIngredientsButton.Text = "Editar";
            this.editIngredientsButton.UseVisualStyleBackColor = true;
            this.editIngredientsButton.Click += new System.EventHandler(this.editIngredientsButton_Click);
            // 
            // Make_EditRecipeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 511);
            this.Controls.Add(this.editIngredientsButton);
            this.Controls.Add(this.tbInstructions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbIngredients);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbRecipeName);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Name = "Make_EditRecipeFrm";
            this.Text = "Crear una receta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button saveButton;
        private Button cancelButton;
        private TextBox tbRecipeName;
        private TextBox tbDescription;
        private Label label1;
        private Label label2;
        private TextBox tbIngredients;
        private Label label3;
        private Label label4;
        private TextBox tbInstructions;
        private Button editIngredientsButton;
    }
}