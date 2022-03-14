using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Contracts
{
    public interface IStore
    {
        public List<Product> Products { get; set; }
        //public List<Product> CartItems { get; set; }
        public double VAT { get; }


        //public void AddStockToProduct(string id, int numberChange);
        public Product AddStockToProduct(string nameOfProduct, decimal price, int quantity = 0);
        public void RemoveProduct(string id);
        public void SetVAT(double newVAT);
        public void UpdateProductPrice(string id, decimal newPrice);

        public Product GetProduct();
    }
}
