using System;
using System.Globalization;
namespace Section_10.Ex2
{
    public class UsedProduct : Product
    {
        DateTime ManufacturedDate { set; get; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufacturedDate) 
            : base(name, price)
        {
            ManufacturedDate = manufacturedDate;
        }

        public override string PriceTag()
        {
            return Name + " (used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + " (Manufactured date: " + ManufacturedDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}
