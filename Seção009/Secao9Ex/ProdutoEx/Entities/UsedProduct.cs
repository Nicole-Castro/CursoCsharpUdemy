using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdutoEx.Entities
{
    public class UsedProduct : Product
    {
        public DateTime ManufacturedDate { get; set; }

        public UsedProduct(){

        }
        public UsedProduct(string name, double price, DateTime manufacturedDate):base(name,price){
            ManufacturedDate = manufacturedDate;
        }

        public override string PriceTag()
        {
            return base.PriceTag();
        }
        public override string ToString()
        {
            return Name + " (used) $ " + PriceTag() + " (Manufactured date: "+ ManufacturedDate.ToString("dd/MM/yyyy") +")";
        }

    }
}