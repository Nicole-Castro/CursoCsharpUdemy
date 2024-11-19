using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ProdutoEx.Entities
{
    public class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct(){

        }
        public ImportedProduct(string name, double price, double customFee):base(name ,price){
            CustomFee = customFee;
        }
        
        public override string PriceTag()
        {
            return TotalPrice().ToString("F2",CultureInfo.InvariantCulture);
        }

        public double TotalPrice(){
            return Price + CustomFee;
        }
        override public string ToString(){
            return Name + " $ " + PriceTag() + " (Custom fee: $"+ CustomFee.ToString("F2",CultureInfo.InvariantCulture) +")";
        }
    }
}