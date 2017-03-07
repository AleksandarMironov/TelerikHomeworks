using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Common;
using Cosmetics.Contracts;

namespace Cosmetics.Products
{
    public class Toothpaste : Products, IProduct, IToothpaste
    {
        private List<string> ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, string ingredients) : base(name, brand, price, gender)
        {
            this.Ingredients = ingredients;
        }

        public string Ingredients
        {
            get
            {
                return String.Join(", ", this.ingredients);
            }
            set
            {
                List<string> temp = value.Split(',').ToList();
                foreach (var item  in temp)
                {
                    Validator.CheckIfStringLengthIsValid(item,12,4, String.Format(GlobalErrorMessages.IngredientInvalidStringLength, 4, 12));
                }
                this.ingredients = value.Split(',').ToList();
                
            }
        }

        public override string Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("  * Ingredients: " + this.Ingredients);
            return base.Print() + sb.ToString();
        }
    }
}
