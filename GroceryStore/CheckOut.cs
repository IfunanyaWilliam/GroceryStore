using GroceryStore;
using GroceryStore.Contracts;

namespace GroceryStore
{
 
    public class CheckOut
    {

        private readonly IStore _store;

        public CheckOut(IStore store)
        { 
            _store = store; 
        }
             
        
        //GenerateReceipt Method
        

        public decimal CalculateDiscount(string id, double discountRate)
        {
            //discount variable is a decimal because the m appended to it
            var discount = 0m; 
                foreach (var item in _store.Products)
                {
                    if (item.Id == id)
                    {
                    //convert double to a decimal since decimal is more accurate
                   discount = item.Price - (item.Price * (decimal)discountRate);  
                    }
                }
                return discount;

        }


        public decimal CalculateVAT(decimal totalPrice)
        {
            decimal vattedPrice = 0m;
            //VAT comes as a decimal percentage eg 0.75% so divide the 0.75 by 100
            vattedPrice = totalPrice + (totalPrice * (decimal)_store.VAT / 100);
            return vattedPrice;
        }
    }

}


