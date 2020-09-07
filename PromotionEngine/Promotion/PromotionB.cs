using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Promotion
{
    public class PromotionB : IPromotion
    {
        protected int price = 30;
        protected int comboCount = 2;
        protected int comboPrice = 45;
        protected int countCombo, remainingCombo, finalPrice = 0;

        public int CalculatePrice(int productCount)
        {
            countCombo = productCount / comboCount;
            remainingCombo = productCount % comboCount;
            finalPrice = (comboPrice * countCombo) + (30 * remainingCombo);
            return finalPrice;
        }

    }
}
