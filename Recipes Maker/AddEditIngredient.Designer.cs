namespace Recipes_Maker
{
    partial class Add_EditIngredient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nupQuantity = new System.Windows.Forms.NumericUpDown();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbIngredient = new System.Windows.Forms.ComboBox();
            this.accetpButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoría:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrediente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad:";
            // 
            // nupQuantity
            // 
            this.nupQuantity.Location = new System.Drawing.Point(28, 134);
            this.nupQuantity.Name = "nupQuantity";
            this.nupQuantity.Size = new System.Drawing.Size(120, 23);
            this.nupQuantity.TabIndex = 3;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(27, 44);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 23);
            this.cbCategory.TabIndex = 4;
            // 
            // cbIngredient
            // 
            this.cbIngredient.FormattingEnabled = true;
            this.cbIngredient.Location = new System.Drawing.Point(27, 90);
            this.cbIngredient.Name = "cbIngredient";
            this.cbIngredient.Size = new System.Drawing.Size(121, 23);
            this.cbIngredient.TabIndex = 5;
            // 
            // accetpButton
            // 
            this.accetpButton.Location = new System.Drawing.Point(12, 175);
            this.accetpButton.Name = "accetpButton";
            this.accetpButton.Size = new System.Drawing.Size(75, 23);
            this.accetpButton.TabIndex = 6;
            this.accetpButton.Text = "Aceptar";
            this.accetpButton.UseVisualStyleBackColor = true;
            this.accetpButton.Click += new System.EventHandler(this.accetpButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(93, 175);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Add_EditIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 215);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.accetpButton);
            this.Controls.Add(this.cbIngredient);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.nupQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_EditIngredient";
            this.Text = "Add_EditIngredient";
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown nupQuantity;
        private ComboBox cbCategory;
        private ComboBox cbIngredient;
        private Button accetpButton;
        private Button cancelButton;
    }
}