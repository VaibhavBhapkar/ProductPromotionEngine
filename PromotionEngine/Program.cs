using PromotionEngine.Factory;
using PromotionEngine.Promotion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loopContinue = true;
            while (loopContinue)
            {
                Console.WriteLine("Commiting New Changes with push");
                Console.WriteLine("Please Enter Option No. 1)Product Price Calculation");
                int option = Convert.ToInt32(Console.ReadLine());
                List<SkuProduct> prodList = new List<SkuProduct>();
                SkuProduct productA = new SkuProduct();
                SkuProduct productB = new SkuProduct();
                SkuProductCombo productCombo = new SkuProductCombo();
                int count, total, finalAmount = 0;
                List<int> finalPrice = new List<int>();
                PromotionFactory promofactory = new PromotionFactory();
                PromotionCombinationFactory prmoCombFacory = new PromotionCombinationFactory();

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter no. of prod to buy for Product A");
                        count = Convert.ToInt32(Console.ReadLine());
                        productA.SkuName = "A";
                        productA.count = count;
                        prodList.Add(productA);
                        Console.WriteLine("Enter no. of prod to buy for Product B");
                        count = Convert.ToInt32(Console.ReadLine());
                        productB.SkuName = "B";
                        productB.count = count;
                        prodList.Add(productB);
                        Console.WriteLine("Enter no. of prod to buy for Product C");
                        count = Convert.ToInt32(Console.ReadLine());
                        productCombo.SkuName1 = "C";
                        productCombo.count1 = count;
                        Console.WriteLine("Enter no. of prod to buy for Product D");
                        count = Convert.ToInt32(Console.ReadLine());
                        productCombo.SkuName2 = "D";
                        productCombo.count2 = count;
                        foreach (SkuProduct prod in prodList)
                        {
                            IPromotion promo = promofactory.GetPromoOffer(prod.SkuName);
                            total = promo.CalculatePrice(prod.count);
                            finalPrice.Add(total);
                        }
                        IPromotionCombined promocomb = prmoCombFacory.GetPromoOffer(productCombo.SkuName1, productCombo.SkuName2);
                        total = promocomb.CalculatePrice(productCombo.count1, productCombo.count2);
                        finalPrice.Add(total);
                        foreach (int val in finalPrice)
                        {
                            finalAmount = finalAmount + val;
                        }
                        Console.WriteLine(finalAmount);
                        break;
                    default:
                        Console.WriteLine("Value didn’t match earlier.");
                        break;
                }

            }      

            
        }
    }
}
