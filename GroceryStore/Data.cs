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
        SqlCommand      com;
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
        public void RemoveProduct(string prodID)
        {
            int prodIndex = 0;
            foreach (var item in Products)
            {
                if (item.Id == prodID)
                {
                    prodIndex = Products.IndexOf(item);
                }
            }

            Products.RemoveAt(prodIndex);
            string removeProd = $"delete from tblProduct where Id = '{prodID}'";
            using (conn = new SqlConnection(_connString))
            {
                conn.Open();
                com = new SqlCommand(removeProd, conn);
                com.ExecuteNonQuery();
                conn.Close();
            }
           
            
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
                com = new SqlCommand(selectProd, conn);
                conn.Open();
                reader = com.ExecuteReader();
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

        public void GeAlltProduct()
        {
            string selectProd = "select * from tblProduct";
            using (conn = new SqlConnection(_connString))
            {
                com = new SqlCommand(selectProd, conn);
                conn.Open();
                reader = com.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Products.Add(new Product(reader.GetString(0))
                        {
                            Name = reader.GetString(1),
                            Price = reader.GetInt32(2),
                            Quantity = reader.GetInt32(3),
                            
                        });
                    }
                }
            }
        }

        public void AddNewProduct(Product prod)
        {
           
            {
                string insertQuery = $"insert into tblProduct values ('{prod.Id}', '{prod.Name}', {prod.Price}, {prod.Quantity})";
                using (conn = new SqlConnection(_connString))
                {
                    com = new SqlCommand(insertQuery, conn);
                    conn.Open();
                    com.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public bool UpdateProdQuantity(string id, int quantity)
        {
            string updateProd = $"update tblProduct set Quantity = @Quantity where Id = @Id";
            try
            {
                using (conn = new SqlConnection(_connString))
                {
                    com = new SqlCommand(updateProd, conn);
                    com.Parameters.AddWithValue("@Quantity", quantity);
                    com.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    com.ExecuteNonQuery();
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

    }
}
