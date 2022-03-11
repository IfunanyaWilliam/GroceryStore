using System;
using GroceryStore;
using GroceryStore.Contracts;


namespace GroceryStoreUserInterface
{
    public partial class Login : Form
    {
        public IStore product { get; set; }

        public RoleType role { get; set; }

        public Login(IStore store)
        {
            InitializeComponent();
            errorMessage.Visible = false;
            product = store;
            
        }

        string staffPassword    = "s101";
        string adminPaword      = "a101";
        string staffName        = "staff1";
        string adminName        = "admin1"; 

        private void label1_Click(object sender, EventArgs e)
        {
             
        }

        private void Password_label_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Username_textBox_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            if(Username_textBox.Text == staffName && Password_Text.Text == staffPassword)
            {
                
                //MessageBox.Show(message);
                var checkOut = new CheckOutUI(product, RoleType.Staff);
                checkOut.Show();
            }
            else if(Username_textBox.Text == adminName && Password_Text.Text == adminPaword)
            {
                var checkOut = new CheckOutUI(product, RoleType.Manager);
                Username_textBox.Text = "";
                Password_Text.Text = "";
                checkOut.Show();
                
            }
            else
            {
                errorMessage.Visible = true;
                errorMessage.Text = "Wrong Username or Password";
                Username_textBox.Text = "";
                Password_Text.Text = "";
            }
                     

        }

        private void Password_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void errorMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            //Username_textBox   Password_Text
        }
    }
}