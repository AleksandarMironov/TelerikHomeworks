using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Common;
using Cosmetics.Contracts;

namespace Cosmetics
{
    public class Category:ICategory
    {


        private const int minCategoryNameLength = 2;
        private const int maxCategoryNameLength = 15;
        private string name;
        private ICollection<IProduct> productList; 


        public string Name
        {
            get
            {
                return this.name;
                
            }

            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, String.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, this.GetType().Name + " name"));
                Validator.CheckIfStringLengthIsValid(value, maxCategoryNameLength, minCategoryNameLength, String.Format(GlobalErrorMessages.InvalidStringLength, this.GetType().Name + " name", maxCategoryNameLength, minCategoryNameLength));

                this.name = value;
                
            }
        }

        public ICollection<IProduct> ProductList
        {
            get
            {
                return new List<IProduct>(productList.OrderBy(n => n.Name).ThenByDescending(p => p.Price));
                
            }
            set
            {
                this.productList = value;
                
            }
        } 

        public void AddCosmetics(IProduct cosmetics)
        {
            this.productList.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            if (!this.productList.Contains(cosmetics))
            {
                throw new ArgumentException(String.Format(GlobalErrorMessages.ProductDoesNotExist, this.Name, this.GetType().Name));
            }
            else
            {
                this.productList.Remove(cosmetics);
            }
        }

        public string Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" ");
            sb.Append(this.GetType());
            sb.Append(" category – ");
            sb.Append(this.productList.Count);
            sb.Append(" products/product in total");
            sb.Append(Environment.NewLine);
            foreach (var item  in this.ProductList)
            {
                sb.AppendLine(item.Print());
            }

            Console.WriteLine(sb.ToString());
            return sb.ToString();

        }

        public Category(string name)   ////da poly4ava list?
        {
            this.Name = name;
            this.ProductList = new List<IProduct>();
        }
    }
}
