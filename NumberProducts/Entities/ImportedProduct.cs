using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace NumberProducts.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }
         
        public double TotalPrice()
        {
            Price += CustomsFee;
            return Price;
        }

        public override string PriceTag() //em meu override eu posso alterar meu PriceTag, da forma que bem entender
        {
            return Name + " " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + " (Customs fee: $ " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }

}
