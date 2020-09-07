using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Promotion
{
    public class PromotionA : IPromotion
    {
        protected int price = 50;
        protected int comboCount = 3;
        protected int comboPrice = 130;
        protected int countCombo,remainingCombo,finalPrice = 0;

        public int CalculatePrice(int productCount)
        {
            countCombo = productCount / comboCount;
            remainingCombo = productCount % comboCount;
            finalPrice = (comboPrice * countCombo) + (50 * remainingCombo);
            return finalPrice;
        }
    }
}
