using PromotionEngine.Promotion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Factory
{
    public class PromotionCombinationFactory
    {
        public IPromotionCombined GetPromoOffer(string productName,string productname2)
        {
            IPromotionCombined returnVal = null;
            if (productName == "C" && productname2=="D")
            {
                returnVal = new PromotionCandD();
            }
            
            return returnVal;
        }
    }
}
