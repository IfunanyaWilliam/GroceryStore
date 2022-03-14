using GroceryStore;
using GroceryStore.Contracts;


namespace GroceryStoreUserInterface
{
    public partial class CheckOutUI : Form
    {
        private readonly IStore _store;

        public RoleType roleType;
        public List<Cart> CartItems { get; set; } = new List<Cart>();

        public int ItemCount { get; set; }

        public int AddREmoveDisplayCounter { get; set; }

        private Database databaseObject;

        public Database DatabaseObject
        {
            get {
                if(databaseObject == null)
                    {
                        databaseObject = new Database();
                    }
                return databaseObject;
                }
            set { databaseObject = value; }
        }


        public CheckOutUI(IStore store, RoleType role)
        {
            InitializeComponent(); 
            ItemCount = 0;
            AddREmoveDisplayCounter = 0;
            DisplayCount.Text = ItemCount.ToString();
            AddREmoveDisplay.Text = AddREmoveDisplayCounter.ToString();
            _store = store;
            DisplayProducts();
            CartItems.Clear();
            roleType = role;
            CheckRole();
        }



        private void RemoveProduct_Click(object sender, EventArgs e)
        {
            ItemCount--;
            DisplayCount.Text = ItemCount.ToString();
            if (ItemCount <= 0) //Check if number of items is negative
            {
                ItemCount = 0;
                DisplayCount.Text = ItemCount.ToString();

            }
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            ItemCount++;
            DisplayCount.Text = ItemCount.ToString();
        }

        private void DisplayCount_TextChanged(object sender, EventArgs e)
        {
            //ItemCount = 1;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           //ProductList.ReadOnly = true;
        }

        private void DisplayProducts()
        {
            string displayText = "";
            DatabaseObject.Products.Clear();
            DatabaseObject.GeAlltProduct();
            foreach (Product product in DatabaseObject.Products)
            {
                if(product.Quantity <= 0)
                {
                    continue;
                }
                displayText += $"Name: {product.Name} \n Price: #{product.Price} \n Quantity: {product.Quantity} \n Id: {product.Id}\n\n";
            }
            ProductList.Text = displayText;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            AddREmoveDisplayCounter ++;
            AddREmoveDisplay.Text = AddREmoveDisplayCounter.ToString();
        }

        private void AddProdToCart_Click(object sender, EventArgs e)
        {
            //CheckOutBox
            string name = "";
            decimal itemPrice = 0;
            int quantity;
            decimal subTotal = 0;
            int seriallNo = 1;
            

            foreach (Product prod in _store.Products)
            {
                if(prod.Id == Product_Id.Text)
                {
                    quantity = Convert.ToInt32(DisplayCount.Text);
                    subTotal = itemPrice * quantity;
                    int newQuantity = prod.Quantity - quantity;
                    
                    bool prodUpdate = DatabaseObject.UpdateProdQuantity(prod.Id, newQuantity);
                    if (prodUpdate)
                    {
                        AddProductsToCarts(prod, quantity);
                        DisplayCartItems();
                        TotalTextBox.Text = CalculateTotal();

                    }
                    //DisplayProducts();
                }
                

            }

            DisplayProducts();
            DisplayCount.Text = "";
            Product_Id.Text = "";
            ItemCount = 0;
            seriallNo++;
            
        }

        public string CalculateTotal()
        {
            var total = CartItems.Sum( s => s.SubTotal);
            return "# " + total.ToString();
        }

        public void AddProductsToCarts(Product prod, int quantity)
        {
            var checkCart = CartItems.Find(k =>k.Id == prod.Id);
            if (checkCart == null)
            {
                CartItems.Add(
                    new Cart()
                    {
                        Id = prod.Id,
                        Name = prod.Name,
                        Price = prod.Price,
                        Quantity = quantity,
                        SubTotal = quantity * prod.Price
                    });
            }
            else
            {
                checkCart.Quantity += quantity;
                checkCart.SubTotal = checkCart.Quantity * checkCart.Price;
            }
        }

        public void DisplayCartItems()
        {
            CartGridView.Rows.Clear();
            int serialNum = 1;
            foreach(Cart cart in CartItems)
            {
                CartGridView.Rows.Add(serialNum, cart.Name, cart.Price, cart.Quantity, cart.SubTotal);
                serialNum++;
            }
            
        }

        private void AddREmoveDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void RemoveProductField_Click(object sender, EventArgs e)
        {
            AddREmoveDisplayCounter --;
            AddREmoveDisplay.Text = AddREmoveDisplayCounter.ToString();
            if (AddREmoveDisplayCounter <= 0) //Check if number of items is negative
            {
                AddREmoveDisplayCounter = 0;
                AddREmoveDisplay.Text = ItemCount.ToString();

            }
        }

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


        public void CheckRole()
        {
            if (roleType == RoleType.Manager)
            {
                //MessageBox.Show("You are manager");
                LoginMessage.Text = "You are logged in as Manager";
                AdminBox.Visible = true;
            }
            else  
            {
                LoginMessage.Text = "You are logged in as Staff";
                AdminBox.Visible = false;

            }

        }

        private void RemoveProductField_Click_2(object sender, EventArgs e)
        {
            AddREmoveDisplayCounter--;
            AddREmoveDisplay.Text = AddREmoveDisplayCounter.ToString();
            if (AddREmoveDisplayCounter <= 0) //Check if number of items is negative
            {
                AddREmoveDisplayCounter = 0;
                AddREmoveDisplay.Text = ItemCount.ToString();  
                
            }
        }

        private void AddItem_Click_2(object sender, EventArgs e)
        {
            AddREmoveDisplayCounter++; 
            AddREmoveDisplay.Text = AddREmoveDisplayCounter.ToString(); 
        }

        private void RemoveProductBtn_Click_1(object sender, EventArgs e)
        {
            //_store.RemoveProduct(RemoveProductBox.Text);
            DatabaseObject.RemoveProduct(RemoveProductBox.Text);
            RemoveProductBox.Text = "";
            DisplayProducts();
            MessageBox.Show("Product has been removed from Stock");
        }


        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            ClearCart();
            this.Close();
        }

        private void ClearCartBtn_Click(object sender, EventArgs e)
        {
            ClearCart();
        }

        public void ClearCart()
        {
            if (CartGridView.Rows.Count > 1 && CartGridView.Rows != null)
            {
                //MessageBox.Show(this.Name);
                foreach (var cart in CartItems)
                {
                    var prodIndex = DatabaseObject.Products.FindIndex((data) => data.Id == cart.Id);
                    var quantity = DatabaseObject.Products[prodIndex].Quantity + cart.Quantity;
                    DatabaseObject.UpdateProdQuantity(cart.Id, quantity);
                }
                DisplayProducts();
                CartItems.Clear();
                TotalTextBox.Text = "";
                CartGridView.Rows.Clear();
            }
        }

        private void AddProductBtn_Click_2(object sender, EventArgs e)
        {
            var prod = new Product(AddProductField.Text, int.Parse(AddREmoveDisplay.Text)) { Price = (decimal.Parse(ProductPriceField.Text)) };
            DatabaseObject.AddNewProduct(prod);
            DisplayProducts();
            AddProductField.Text = "";
            AddREmoveDisplay.Text = "";
            ProductPriceField.Text = "";
        }


        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{

        //}

        //private void CheckOutBox_TextChanged(object sender, EventArgs e)
        //{
        //    //CheckOutBox
        //}

        ////Add new product with Name, Quantity, Price. Call DisplayProduct() to display updated list of Product
        //private void AddProductBtn_Click(object sender, EventArgs e)
        //{

        //    var prod = new Product(AddProductField.Text, int.Parse(AddREmoveDisplay.Text)) { Price = (decimal.Parse(ProductPriceField.Text)) };
        //    _store.Products.Add(prod);
        //    DisplayProducts();
        //    AddProductField.Text = "";
        //    AddREmoveDisplay.Text = "";
        //    ProductPriceField.Text = "";


        //}

        //private void RemoveProductBtn_Click(object sender, EventArgs e)
        //{

        //}

        //private void ProductPriceField_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void AddREmoveDisplay_TextChanged_1(object sender, EventArgs e)
        //{

        //}

        //private void AddRemoveBtn_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void RemoveProductField_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void AddItem_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void AddProductField_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void AddProductLabel_Click(object sender, EventArgs e)
        //{

        //}

    }
}
