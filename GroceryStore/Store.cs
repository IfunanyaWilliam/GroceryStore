using GroceryStore.Contracts;

namespace GroceryStore
{  

    public class Store : IStore
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public double VAT { get; private set; }

        public void UpdateProductPrice(string id, decimal newPrice)
        {
            foreach (var item in Products)
            {
                if (item.Id == id) { item.Price = newPrice; }
            }
        }


        /// <summary>
        /// A method that returns the VAT
        /// </summary>
        /// <param name="newVAT"></param>
        public void SetVAT(double newVAT)
        {
            VAT = newVAT;
        }


        public void RemoveProduct(string id)
        {
            int check = 0;
            foreach (var item in Products)
            {
                if (item.Id == id) 
                {
                    check = Products.IndexOf(item);
                }
            }
            Products.RemoveAt(check);
        }


        /// <summary>
        /// A method that creates a new product
        /// </summary>
        /// <param name="nameOfProduct"></param>
        /// <param name="price"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public Product AddStockToProduct(string nameOfProduct, decimal price, int quantity = 0)
        {
            Product prod = new Product(nameOfProduct, quantity) { Price = price};
            Products.Add(prod);
            return prod;
        }


        public Product GetProduct()
        {
            Product result = new Product();
            foreach (var item in Products)
            {
                
            }
            return result;
        }

       
    }

}


