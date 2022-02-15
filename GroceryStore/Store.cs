namespace GroceryStore
{
    public class Store
    {
        public List<Product> Products { get; set;} = new List<Product>();
        public double VAT { get; private set; }

        public void UpdateProductPrice(string id, decimal newPrice)
        {
            foreach (var item in Products)
            {
                if(item.Id == id) { item.Price = newPrice; }
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


       

        public void AddStockToProduct(string id, int numberChange)
        {
            foreach(var item in Products)
            {
                if(item.Id == id) { item.Quantity += numberChange; }
            }
        }


        public void RemoveStockFromProduct(string id, int numberChange)
        {
            foreach (var item in Products)
            {
                if (item.Id == id) { item.Quantity -= numberChange; }
            }
        }


        //Polymophism of CreateProduct
        public string CreateProduct(string nameOfProduct, int quantity = 0)
        {
            Product prod = new Product(nameOfProduct, quantity);
            Products.Add(prod);
            return prod.Id;
        }


        

    }

}


