using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {  
            int[] inputArray = new int[] { 45, 24, 35, 31, 40, 38, 11 };

            Profit profit = new Profit();
            BestPrice bestPrice=profit.FindProfit(inputArray);
            Console.WriteLine("Highest price is " +bestPrice.highest);
            Console.WriteLine("Lowest price is " + bestPrice.lowest);
            //int finalprofit = bestPrice.highest - bestPrice.lowest;
            Console.WriteLine("Profit=" +(bestPrice.highest-bestPrice.lowest));
            Console.ReadLine();
        }
    }
    public class Profit
    {
        public BestPrice FindProfit(int[] inputArray)
        {
            BestPrice bestPrice = new BestPrice();
            bestPrice.highest = -1;
            bestPrice.lowest = -1;
            int diff = 0;
            for(int i =0,l= inputArray.Length; i<l-1;i++)
            {
                for(int j=i+1;j<l;j++)
                {
                    int stockDiff = inputArray[j] - inputArray[i];
                    if(diff<stockDiff)
                    {
                        diff = stockDiff;
                        bestPrice.highest = inputArray[j];
                        bestPrice.lowest = inputArray[i];
                    }
                }
            }
            return bestPrice;
        }
    }
    public class BestPrice
    {
        public int highest { get; set; }
        public int lowest { get; set; }
        public int getProfit() {
            return
                highest - lowest;
        }

    }
}
