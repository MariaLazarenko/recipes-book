//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RecipeBook
{
    using System;
    using System.Collections.Generic;
    
    public partial class Composition
    {
        public int Id { get; set; }
        public int IngredientId { get; set; }
        public int Amount { get; set; }
        public int RecipeId { get; set; }
    
        public virtual Ingredient Ingredient { get; set; }
        public virtual Recipe Recipe { get; set; }
    }
}
