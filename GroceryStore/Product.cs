namespace GroceryStore
{
    public class Product
    {
        //This constructor implements polymophism
        public Product(string productName, int quantity = 0)
        {
            Id = Guid.NewGuid().ToString();
            Name = productName;
            Quantity = quantity;
        }


        public string Id { get; }  // The Guid is readonly

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }


    }
}


    


