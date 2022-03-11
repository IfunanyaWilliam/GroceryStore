using GroceryStore.Contracts;
namespace GroceryStore
{
    

    public class Product : IProduct
    {
        //This constructor implements polymophism
        public Product()
        {
            Id = Guid.NewGuid().ToString();
        }

        public Product(string id)
        {
            Id = id;
        }
        public Product(string name, int quantity)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Quantity = quantity;
        }


        public string Id { get; }  // The Guid is readonly

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }


    }
}


    


