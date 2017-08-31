using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountEngineCS
{
    public interface IDiscountEngine
    {
        void Compute(ref PurchaseOrder poList);
    }
}
