using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace GroceryStore.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
             
        }

        void button_Click(object sender, RoutedEventArgs e)
        {
            // Show message box when button is clicked.
            MessageBox.Show("Hello Ifunanya!, Welcome to WPF Tech World"); //Login
        }

        void ProcessLogin(object sender, RoutedEventArgs e)
        {
            string staffPassword = "101";
            string staffUserName = "staff1";
            string managerPassword = "102";
            string managerUserName = "Manager1";
            

            // Show message box when button is clicked.
             MessageBox.Show("Hello Ifunanya!, Welcome to WPF Tech World");

            

        }






    }


    public partial class GroceryStockUI : Window
    {
        public GroceryStockUI()
        {
            var mainWindow = new MainWindow();
            mainWindow.InitializeComponent();

        }



    }





}
