using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Promotion
{
    // Defining interface for calculating price
    public interface IPromotionCombined
    {
        int CalculatePrice(int prodCountC, int prodCountD);
    }
}
