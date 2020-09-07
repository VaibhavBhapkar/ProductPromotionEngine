using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Promotion
{
    public class PromotionCandD : IPromotionCombined
    {
        protected int cPrice = 20;
        protected int dPrice = 15;
        protected int comboPrice = 30;
        protected int finalPrice = 0;
        public int CalculatePrice(int prodCountC, int prodCountD)
        {
            if(prodCountC==prodCountD)
            {
                finalPrice = comboPrice * prodCountC;
            }
            else
            {
                if(prodCountC>prodCountD)
                {
                    finalPrice = (comboPrice * prodCountD) + (20 * (prodCountC - prodCountD));
                }
                else
                {
                    finalPrice = (comboPrice * prodCountC) + (15 * (prodCountD - prodCountC));
                }
            }
            return finalPrice;
        }
    }
}
