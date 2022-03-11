using GroceryStore;
using GroceryStore.Contracts;


namespace GroceryStoreUserInterface
{
    public partial class CheckOutUI : Form
    {
        private readonly IStore _store;

        public RoleType roleType;

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
            roleType = role;
            CheckRole();
            //CheckOutBox.Text = Role.RoleType.Manager.ToString(); 
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
            foreach (Product product in _store.Products)
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

        private void EnterItem_Click(object sender, EventArgs e)
        {
            //CheckOutBox
            var cartitem = _store.CartItems;
            string name = "";
            decimal itemPrice = 0;
            int quantity = 0;
            decimal subTotal = 0;
            int checkOutItemCount = 0;
            string displayCartText = "";

            foreach (Product product in _store.Products)
            {
                //displayText += $"Name: {product.Name} \n Price: #{product.Price} \n Quantity: {product.Quantity} \n Id: {product.Id}\n\n";
                if(product.Id == Product_Id.Text)
                {
                    
                    
                    quantity    = Convert.ToInt32(DisplayCount.Text);
                }
                subTotal = product.Price * quantity;
                displayCartText = $"{checkOutItemCount} \t {name} \t {itemPrice} \t {subTotal}";
            }
            CheckOutBox.Text = displayCartText;
            DisplayCount.Text = "";
            Product_Id.Text = "";
            ItemCount = 0;
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

        private void AddRemoveBtn_Click_2(object sender, EventArgs e)
        {
            if(AddREmoveDisplay.Text == "" || ProductPriceField.Text == "")
            {
                MessageBox.Show("Pleaase add product Price or Quantity");
                ProductPriceField.Focus();  
            }
            else
            {
                var productId = _store.AddStockToProduct(AddProductField.Text, decimal.Parse(ProductPriceField.Text), int.Parse(AddREmoveDisplay.Text));
                DisplayProducts();
                DatabaseObject.AddNewProduct(productId);
                AddProductField.Text = "";
                AddREmoveDisplay.Text = "";
                ProductPriceField.Text = "";
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
            _store.RemoveProduct(RemoveProductBox.Text);
            DisplayProducts();
            RemoveProductBox.Text = "";
        }


        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            string message = "Ensure you have printed receipt for the purchased items\n" +
                             "OR you have retured the items to stock by clearing cart\n" +
                             "Do you still want to Log Out";
            string title = "Log out Warning";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, button);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
           
        }


        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{

        //}

        //private void CheckOutBox_TextChanged(object sender, EventArgs e)
        //{
        //    //CheckOutBox
        //}

        ////Add new product with Name, Quantity, Price. Call DisplayProduct() to display updated list of Product
        //private void AddRemoveBtn_Click(object sender, EventArgs e)
        //{

        //    //var prod = new Product(AddProductField.Text, int.Parse(AddREmoveDisplay.Text)) { Price = (decimal.Parse(ProductPriceField.Text)) };
        //    //_store.Products.Add(prod);
        //    //DisplayProducts();
        //    //AddProductField.Text = "";
        //    //AddREmoveDisplay.Text = "";
        //    //ProductPriceField.Text = "";


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
