using System;
using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart.Tests
{
    public class GetBookPrice
    {
        public GetBookPrice()
        {
        }

        internal int CalculatePrice(List<int> bookCount)
        {
            int price = default(int);
            do
            {
                bookCount = bookCount
                    .Where(r => r - 1 >= 0)
                    .Select(r => r - 1)
                    .ToList();
                price += GetPrice(bookCount.Count);

            } while (bookCount.Count > 0);
            
            return price;
        }

        private int GetPrice(int bookset)
        {
            int originalprice = 100 * bookset;
            switch (bookset)
            {
                case 2:
                    return (int)(originalprice * 0.95);
                case 3:
                    return (int)(originalprice * 0.9);
                case 4:
                    return (int)(originalprice * 0.8);
                case 5:
                    return (int)(originalprice * 0.75);
                default:
                    break;
            }
            return originalprice;
        }
    }
}