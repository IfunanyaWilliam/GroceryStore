namespace GroceryStoreUserInterface
{
    partial class CheckOutUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Product = new System.Windows.Forms.Label();
            this.Product_Id = new System.Windows.Forms.TextBox();
            this.AddProductSale = new System.Windows.Forms.Button();
            this.RemoveProduct = new System.Windows.Forms.Button();
            this.CheckOutBox = new System.Windows.Forms.TextBox();
            this.PrintReceipt = new System.Windows.Forms.Button();
            this.LoginMessage = new System.Windows.Forms.TextBox();
            this.DisplayCount = new System.Windows.Forms.TextBox();
            this.AddProdToCart = new System.Windows.Forms.Button();
            this.ProductList = new System.Windows.Forms.RichTextBox();
            this.Cart = new System.Windows.Forms.Label();
            this.AdminBox = new System.Windows.Forms.GroupBox();
            this.RemoveProductBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveProductBox = new System.Windows.Forms.TextBox();
            this.ProductPriceField = new System.Windows.Forms.TextBox();
            this.AddREmoveDisplay = new System.Windows.Forms.TextBox();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.RemoveProductField = new System.Windows.Forms.Button();
            this.AddItem = new System.Windows.Forms.Button();
            this.AddProductField = new System.Windows.Forms.TextBox();
            this.AddProductLabel = new System.Windows.Forms.Label();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.ClearCartBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.CartGridView = new System.Windows.Forms.DataGridView();
            this.serial_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(539, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(131, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "CHECKOUT";
            // 
            // Product
            // 
            this.Product.AutoSize = true;
            this.Product.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Product.Location = new System.Drawing.Point(26, 28);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(106, 30);
            this.Product.TabIndex = 1;
            this.Product.Text = "Products";
            // 
            // Product_Id
            // 
            this.Product_Id.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Product_Id.Location = new System.Drawing.Point(18, 326);
            this.Product_Id.Name = "Product_Id";
            this.Product_Id.PlaceholderText = "Enter Product Id";
            this.Product_Id.Size = new System.Drawing.Size(347, 30);
            this.Product_Id.TabIndex = 2;
            // 
            // AddProductSale
            // 
            this.AddProductSale.BackColor = System.Drawing.Color.ForestGreen;
            this.AddProductSale.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddProductSale.ForeColor = System.Drawing.SystemColors.MenuText;
            this.AddProductSale.Location = new System.Drawing.Point(42, 385);
            this.AddProductSale.Name = "AddProductSale";
            this.AddProductSale.Size = new System.Drawing.Size(45, 48);
            this.AddProductSale.TabIndex = 3;
            this.AddProductSale.Text = "+";
            this.AddProductSale.UseVisualStyleBackColor = false;
            this.AddProductSale.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // RemoveProduct
            // 
            this.RemoveProduct.BackColor = System.Drawing.Color.IndianRed;
            this.RemoveProduct.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoveProduct.Location = new System.Drawing.Point(124, 385);
            this.RemoveProduct.Name = "RemoveProduct";
            this.RemoveProduct.Size = new System.Drawing.Size(45, 48);
            this.RemoveProduct.TabIndex = 4;
            this.RemoveProduct.Text = " -";
            this.RemoveProduct.UseVisualStyleBackColor = false;
            this.RemoveProduct.Click += new System.EventHandler(this.RemoveProduct_Click);
            // 
            // CheckOutBox
            // 
            this.CheckOutBox.Location = new System.Drawing.Point(604, 81);
            this.CheckOutBox.Multiline = true;
            this.CheckOutBox.Name = "CheckOutBox";
            this.CheckOutBox.ReadOnly = true;
            this.CheckOutBox.Size = new System.Drawing.Size(645, 507);
            this.CheckOutBox.TabIndex = 5;
            // 
            // PrintReceipt
            // 
            this.PrintReceipt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PrintReceipt.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrintReceipt.Location = new System.Drawing.Point(1044, 606);
            this.PrintReceipt.Name = "PrintReceipt";
            this.PrintReceipt.Size = new System.Drawing.Size(160, 47);
            this.PrintReceipt.TabIndex = 6;
            this.PrintReceipt.Text = "Print Receipt";
            this.PrintReceipt.UseVisualStyleBackColor = false;
            this.PrintReceipt.Click += new System.EventHandler(this.PrintReceipt_Click);
            // 
            // LoginMessage
            // 
            this.LoginMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginMessage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LoginMessage.Location = new System.Drawing.Point(175, 16);
            this.LoginMessage.Name = "LoginMessage";
            this.LoginMessage.ReadOnly = true;
            this.LoginMessage.Size = new System.Drawing.Size(285, 34);
            this.LoginMessage.TabIndex = 7;
            this.LoginMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DisplayCount
            // 
            this.DisplayCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DisplayCount.Location = new System.Drawing.Point(222, 393);
            this.DisplayCount.Name = "DisplayCount";
            this.DisplayCount.Size = new System.Drawing.Size(40, 34);
            this.DisplayCount.TabIndex = 8;
            this.DisplayCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddProdToCart
            // 
            this.AddProdToCart.BackColor = System.Drawing.Color.IndianRed;
            this.AddProdToCart.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddProdToCart.Location = new System.Drawing.Point(310, 385);
            this.AddProdToCart.Name = "AddProdToCart";
            this.AddProdToCart.Size = new System.Drawing.Size(150, 48);
            this.AddProdToCart.TabIndex = 9;
            this.AddProdToCart.Text = "Add To Cart";
            this.AddProdToCart.UseVisualStyleBackColor = false;
            this.AddProdToCart.Click += new System.EventHandler(this.AddProdToCart_Click);
            // 
            // ProductList
            // 
            this.ProductList.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProductList.Location = new System.Drawing.Point(18, 71);
            this.ProductList.Name = "ProductList";
            this.ProductList.ReadOnly = true;
            this.ProductList.Size = new System.Drawing.Size(479, 230);
            this.ProductList.TabIndex = 10;
            this.ProductList.Text = "";
            // 
            // Cart
            // 
            this.Cart.AutoSize = true;
            this.Cart.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cart.Location = new System.Drawing.Point(712, 33);
            this.Cart.Name = "Cart";
            this.Cart.Size = new System.Drawing.Size(61, 31);
            this.Cart.TabIndex = 11;
            this.Cart.Text = "Cart";
            // 
            // AdminBox
            // 
            this.AdminBox.Controls.Add(this.RemoveProductBtn);
            this.AdminBox.Controls.Add(this.label1);
            this.AdminBox.Controls.Add(this.RemoveProductBox);
            this.AdminBox.Controls.Add(this.ProductPriceField);
            this.AdminBox.Controls.Add(this.AddREmoveDisplay);
            this.AdminBox.Controls.Add(this.AddProductBtn);
            this.AdminBox.Controls.Add(this.RemoveProductField);
            this.AdminBox.Controls.Add(this.AddItem);
            this.AdminBox.Controls.Add(this.AddProductField);
            this.AdminBox.Controls.Add(this.AddProductLabel);
            this.AdminBox.Location = new System.Drawing.Point(18, 467);
            this.AdminBox.Name = "AdminBox";
            this.AdminBox.Size = new System.Drawing.Size(580, 242);
            this.AdminBox.TabIndex = 15;
            this.AdminBox.TabStop = false;
            // 
            // RemoveProductBtn
            // 
            this.RemoveProductBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.RemoveProductBtn.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoveProductBtn.Location = new System.Drawing.Point(366, 122);
            this.RemoveProductBtn.Name = "RemoveProductBtn";
            this.RemoveProductBtn.Size = new System.Drawing.Size(129, 40);
            this.RemoveProductBtn.TabIndex = 35;
            this.RemoveProductBtn.Text = "Remove";
            this.RemoveProductBtn.UseVisualStyleBackColor = false;
            this.RemoveProductBtn.Click += new System.EventHandler(this.RemoveProductBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(344, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 30);
            this.label1.TabIndex = 34;
            this.label1.Text = "Remove Product";
            // 
            // RemoveProductBox
            // 
            this.RemoveProductBox.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoveProductBox.Location = new System.Drawing.Point(324, 69);
            this.RemoveProductBox.Name = "RemoveProductBox";
            this.RemoveProductBox.Size = new System.Drawing.Size(247, 37);
            this.RemoveProductBox.TabIndex = 33;
            // 
            // ProductPriceField
            // 
            this.ProductPriceField.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProductPriceField.Location = new System.Drawing.Point(179, 126);
            this.ProductPriceField.Name = "ProductPriceField";
            this.ProductPriceField.Size = new System.Drawing.Size(106, 39);
            this.ProductPriceField.TabIndex = 32;
            // 
            // AddREmoveDisplay
            // 
            this.AddREmoveDisplay.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddREmoveDisplay.Location = new System.Drawing.Point(131, 126);
            this.AddREmoveDisplay.Name = "AddREmoveDisplay";
            this.AddREmoveDisplay.ReadOnly = true;
            this.AddREmoveDisplay.Size = new System.Drawing.Size(32, 39);
            this.AddREmoveDisplay.TabIndex = 31;
            this.AddREmoveDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AddProductBtn.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddProductBtn.Location = new System.Drawing.Point(106, 188);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(108, 43);
            this.AddProductBtn.TabIndex = 30;
            this.AddProductBtn.Text = "Enter";
            this.AddProductBtn.UseVisualStyleBackColor = false;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click_2);
            // 
            // RemoveProductField
            // 
            this.RemoveProductField.BackColor = System.Drawing.Color.Green;
            this.RemoveProductField.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoveProductField.Location = new System.Drawing.Point(66, 122);
            this.RemoveProductField.Name = "RemoveProductField";
            this.RemoveProductField.Size = new System.Drawing.Size(48, 43);
            this.RemoveProductField.TabIndex = 29;
            this.RemoveProductField.Text = " -";
            this.RemoveProductField.UseVisualStyleBackColor = false;
            this.RemoveProductField.Click += new System.EventHandler(this.RemoveProductField_Click_2);
            // 
            // AddItem
            // 
            this.AddItem.BackColor = System.Drawing.Color.Green;
            this.AddItem.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddItem.Location = new System.Drawing.Point(15, 122);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(45, 43);
            this.AddItem.TabIndex = 28;
            this.AddItem.Text = " +";
            this.AddItem.UseVisualStyleBackColor = false;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click_2);
            // 
            // AddProductField
            // 
            this.AddProductField.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddProductField.Location = new System.Drawing.Point(15, 69);
            this.AddProductField.Name = "AddProductField";
            this.AddProductField.Size = new System.Drawing.Size(283, 34);
            this.AddProductField.TabIndex = 27;
            // 
            // AddProductLabel
            // 
            this.AddProductLabel.AutoSize = true;
            this.AddProductLabel.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddProductLabel.Location = new System.Drawing.Point(77, 24);
            this.AddProductLabel.Name = "AddProductLabel";
            this.AddProductLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddProductLabel.Size = new System.Drawing.Size(157, 31);
            this.AddProductLabel.TabIndex = 26;
            this.AddProductLabel.Text = "Add Product";
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LogOutBtn.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogOutBtn.Location = new System.Drawing.Point(1084, 33);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(135, 42);
            this.LogOutBtn.TabIndex = 16;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = false;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // ClearCartBtn
            // 
            this.ClearCartBtn.BackColor = System.Drawing.Color.IndianRed;
            this.ClearCartBtn.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearCartBtn.Location = new System.Drawing.Point(873, 33);
            this.ClearCartBtn.Name = "ClearCartBtn";
            this.ClearCartBtn.Size = new System.Drawing.Size(144, 42);
            this.ClearCartBtn.TabIndex = 17;
            this.ClearCartBtn.Text = "Clear Cart";
            this.ClearCartBtn.UseVisualStyleBackColor = false;
            this.ClearCartBtn.Click += new System.EventHandler(this.ClearCartBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(683, 606);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 38);
            this.label2.TabIndex = 18;
            this.label2.Text = "Total";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalTextBox.Location = new System.Drawing.Point(795, 606);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(164, 38);
            this.TotalTextBox.TabIndex = 19;
            // 
            // CartGridView
            // 
            this.CartGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CartGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.CartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serial_no,
            this.productName,
            this.price,
            this.quantity,
            this.subTotal});
            this.CartGridView.Location = new System.Drawing.Point(604, 81);
            this.CartGridView.Name = "CartGridView";
            this.CartGridView.ReadOnly = true;
            this.CartGridView.RowHeadersWidth = 51;
            this.CartGridView.RowTemplate.Height = 29;
            this.CartGridView.Size = new System.Drawing.Size(645, 422);
            this.CartGridView.TabIndex = 20;
            // 
            // serial_no
            // 
            this.serial_no.HeaderText = "S/N";
            this.serial_no.MinimumWidth = 6;
            this.serial_no.Name = "serial_no";
            this.serial_no.ReadOnly = true;
            // 
            // productName
            // 
            this.productName.HeaderText = "Name";
            this.productName.MinimumWidth = 6;
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Unit Price(#)";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // subTotal
            // 
            this.subTotal.HeaderText = "Sub Total(#)";
            this.subTotal.MinimumWidth = 6;
            this.subTotal.Name = "subTotal";
            this.subTotal.ReadOnly = true;
            // 
            // CheckOutUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1256, 721);
            this.Controls.Add(this.CartGridView);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClearCartBtn);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.AdminBox);
            this.Controls.Add(this.Cart);
            this.Controls.Add(this.ProductList);
            this.Controls.Add(this.AddProdToCart);
            this.Controls.Add(this.DisplayCount);
            this.Controls.Add(this.LoginMessage);
            this.Controls.Add(this.PrintReceipt);
            this.Controls.Add(this.CheckOutBox);
            this.Controls.Add(this.RemoveProduct);
            this.Controls.Add(this.AddProductSale);
            this.Controls.Add(this.Product_Id);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.textBox1);
            this.Name = "CheckOutUI";
            this.Text = "Form2";
            this.AdminBox.ResumeLayout(false);
            this.AdminBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label Product;
        private TextBox Product_Id;
        private Button AddProductSale;
        private Button RemoveProduct;
        private TextBox CheckOutBox;
        private Button PrintReceipt;
        private TextBox LoginMessage;
        private TextBox DisplayCount;
        private Button AddProdToCart;
        private RichTextBox ProductList;
        private Label Cart;
        private GroupBox AdminBox;
        private TextBox ProductPriceField;
        private TextBox AddREmoveDisplay;
        private Button AddProductBtn;
        private Button RemoveProductField;
        private Button AddItem;
        private TextBox AddProductField;
        private Label AddProductLabel;
        private Button RemoveProductBtn;
        private Label label1;
        private TextBox RemoveProductBox;
        private Button LogOutBtn;
        private Button ClearCartBtn;
        private Label label2;
        private TextBox TotalTextBox;
        private DataGridView CartGridView;
        private DataGridViewTextBoxColumn serial_no;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn subTotal;
    }
}