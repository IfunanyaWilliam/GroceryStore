using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroceryStore.Contracts;


namespace GroceryStore
{
    public class Database : IStore 
    {
        SqlConnection   conn;
        SqlCommand      cmd;
        SqlDataReader   reader;

        private readonly string _connString = @"Data Source = LAPTOP-MLKDD7UQ\SQLEXPRESS; Initial Catalog = GroceryStore; Integrated Security = True";

        public Database()
        {
            GeAlltProduct();
        }

        public List<Product> Products { get; set; } = new List<Product>();
        public List<Product> CartItems { get; set; }
        public double VAT { get; }

        public Product AddStockToProduct(string nameOfProduct, decimal price, int quantity = 0)
        {
            Product prod = new Product(nameOfProduct, quantity) { Price = price };
            Products.Add(prod);
            return prod;
        }
        public void RemoveProduct(string id)
        {

        }

        public void SetVAT(double newVAT)
        {

        }
        public void UpdateProductPrice(string id, decimal newPrice)
        {

        }

        /// <summary>
        /// Get 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product GetProduct()
        {
            string selectProd = "select * from tblProduct where Id = 'id'";
            using (conn = new SqlConnection(_connString))
            {
                cmd = new SqlCommand(selectProd, conn);
                conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Products.Add(new Product(reader.GetString(0))
                        {
                            Name = reader.GetString(1),
                            Quantity = reader.GetInt32(2),
                            Price = reader.GetDecimal(3),
                        });
                    }
                }
            }
            return null;
        }

        public IList<Product> GeAlltProduct()
        {
            string selectProd = "select * from tblProduct";
            using (conn = new SqlConnection(_connString))
            {
                cmd = new SqlCommand(selectProd, conn);
                conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Products.Add(new Product(reader.GetString(0))
                        {
                            Name = reader.GetString(1),
                            Quantity = reader.GetInt32(2),
                            Price = reader.GetInt32(3),
                        });
                    }
                }
            }
            return Products;
        }

        public void AddNewProduct(Product prod)
        {
           
            {
                string insertQuery = $"insert into tblProduct values ('{prod.Id}', '{prod.Name}', {prod.Quantity}, {prod.Price})";
                using (conn = new SqlConnection(_connString))
                {
                    cmd = new SqlCommand(insertQuery, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
