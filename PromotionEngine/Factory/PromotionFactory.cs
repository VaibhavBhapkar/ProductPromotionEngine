using PromotionEngine.Promotion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Factory
{
    public class PromotionFactory
    {
        public IPromotion GetPromoOffer(string productName)
        {
            IPromotion returnVal = null;
            if(productName=="A")
            {
                returnVal = new PromotionA();
            }
            else if(productName=="B")
            {
                returnVal = new PromotionB();
            }
            return returnVal;
        }
    }
}
