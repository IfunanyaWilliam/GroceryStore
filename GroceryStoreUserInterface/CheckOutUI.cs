using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GroceryStore;


namespace GroceryStoreUserInterface
{
    public partial class CheckOutUI : Form
    {
        private readonly IStore _store;

        public RoleType roleType;

        public List<Product> CartItems { get; set; } = new List<Product>();

        public int ItemCount { get; set; }

        public int AddREmoveDisplayCounter { get; set; }

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Product_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckOutBox_TextChanged(object sender, EventArgs e)
        {
            //CheckOutBox
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
                    name        = product.Name;
                    itemPrice   = product.Price;
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

        //Add new product with Name, Quantity, Price. Call DisplayProduct() to display updated list of Product
        private void AddRemoveBtn_Click(object sender, EventArgs e)
        {
            var prod = new Product(AddProductField.Text, int.Parse(AddREmoveDisplay.Text)) { Price = (decimal.Parse(ProductPriceField.Text)) };
            _store.Products.Add(prod);
            DisplayProducts();
            AddProductField.Text = "";
            AddREmoveDisplay.Text = "";
            ProductPriceField.Text = "";
        }

        private void RemoveProductBtn_Click(object sender, EventArgs e)
        {   
            
        }

        private void ProductPriceField_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddREmoveDisplay_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void AddRemoveBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void RemoveProductField_Click_1(object sender, EventArgs e)
        {

        }

        private void AddItem_Click_1(object sender, EventArgs e)
        {

        }

        private void AddProductField_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProductLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddProductLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void AddREmoveDisplay_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void AddRemoveBtn_Click_2(object sender, EventArgs e)
        {
            var prod = new Product(AddProductField.Text, int.Parse(AddREmoveDisplay.Text)) { Price = (decimal.Parse(ProductPriceField.Text)) };

            _store.Products.Add(prod);
            DisplayProducts();
            AddProductField.Text = "";
            AddREmoveDisplay.Text = "";
            ProductPriceField.Text = ""; 
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

        private void AddProductField_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ProductPriceField_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void RemoveProductBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RemoveProductBtn_Click_1(object sender, EventArgs e)
        {
            //Collections cannot be changed in a loop
            int check = 0;
            
            Product productIdCheck = _store.GetProduct(RemoveProductBox.Text);
            if (productIdCheck != null)
            {
                check = _store.Products.IndexOf(productIdCheck);
            }
            _store.Products.RemoveAt(check);
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
    }
}
