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
        public double itemPrice { get; set; }

        public cItem(String number, double price)
        {
            this.itemNumber = number;
            this.itemPrice = price;
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
    }

    public class DiscountEngine
    {
        public DiscountEngine()
        {

        }

        public double Compute(ref PurchaseOrder o)
        {
            return 0;
        }
    }
}
