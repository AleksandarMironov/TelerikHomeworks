using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Common;
using Cosmetics.Contracts;

namespace Cosmetics.Products
{
    public abstract class Products : IProduct
    {
        private const int maxStringLength = 10;
        private const int minProductNameLength = 3;
        private const int minProductBrandLength = 2;


        private decimal price;
        private string name;
        private string brand;
        private GenderType gender;


        public string Name
        {
            get
            {
                return this.name;              
            }

            set
            {
                Validator.CheckIfStringLengthIsValid(value, maxStringLength, minProductNameLength, 
                    String.Format(GlobalErrorMessages.ProductNameInvalidStringLength, minProductNameLength, maxStringLength));
                this.name = value;
                
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }

            set
            {
                Validator.CheckIfStringLengthIsValid(value, maxStringLength, minProductBrandLength,
                    String.Format(GlobalErrorMessages.ProductBrandInvalidStringLength, minProductBrandLength, maxStringLength));
                this.brand = value;

            }
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                this.price = value;

            }
        }
        public GenderType Gender
        {
            get
            {
                return this.gender;
            }

            set
            {
                this.gender = value;

            }
        }

        public Products(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public virtual string Print()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine("- " + this.Brand + " – " + this.Name + ":");
            output.AppendLine("  * Price: $" + this.Price);
            output.Append("  * For gender: " + this.Gender);
            return output.ToString();
        }


    }
}
