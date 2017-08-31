using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountEngineCS
{
    public class POS
    {

        static void Main(string[] args)
        {

        }
    }

    public class cItem
    {
        public String itemNumber { get; set; }
        public double itemOriginalPrice { get; set; }

        public double discountAmt { get; set; }
        public String discountScheme { get; set; }

        public cItem(String number, double originalPrice)
        {
            this.itemNumber = number;
            this.itemOriginalPrice = originalPrice;
        }

    }

    public class PurchaseOrder
    {
        public List<cItem> poList { get; set; }

        public PurchaseOrder()
        {
            poList = new List<cItem>();
        }

        public List<cItem> GetOrders()
        {
            return this.poList;
        }

        public void AddItem(cItem item)
        {
            poList.Add(item);
        }

        public void RemoveItem(String itemNumber)
        {
            for(int i = 0; i < poList.Count; i++)
            {
                if(poList.ElementAt(i).itemNumber.Equals(itemNumber))
                {
                    poList.RemoveAt(i);
                }
            }
        }
    }
}
