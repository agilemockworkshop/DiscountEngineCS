using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountEngineCS
{
    public class ItemRepo
    {

    }

    public class POS
    {
        public void NewOrder()
        {
            Console.WriteLine("Welcome to POS system");
            Console.WriteLine("1) Add item");
            Console.WriteLine("2) Remove item");
            Console.WriteLine("3) Check out");
            Console.Write("Please choose an option: ");
            
            int option = Console.Read();

            PurchaseOrder poList = new PurchaseOrder();

            switch (option)
            {
                case 1:
                    Console.Write("Enter item number: ");
                    String itemNumber = Console.ReadLine();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("WRONG OPTION");
                    break;
            }
        }

        static void Main(string[] args)
        {
            new POS().NewOrder();          
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
