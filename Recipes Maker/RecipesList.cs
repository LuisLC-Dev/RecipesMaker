﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipes_Maker
{
    public partial class RecipesList : Form
    {
        List<Recipe> recipes = new List<Recipe>();
        public RecipesList()
        {
            InitializeComponent();
        }

    }
}
