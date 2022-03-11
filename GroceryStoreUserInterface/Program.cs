using GroceryStore;
using GroceryStore.Contracts;

namespace GroceryStoreUserInterface
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Apply generics in type casting of Factore to IStore instead of object casting
            var store = (IStore)Factory.GenerateDI("Data");
            //store.Products = new List<Product>
            //{
            //    new Product("Iphone XIII", 20){ Price = 2500m},
            //    new Product("HP Pavilion", 10){ Price = 5900m},
            //    new Product("Dell Latitude", 15){ Price = 4500m},
            //    new Product("MacBook Pro", 40){ Price = 9500m},
            //    new Product("Samsung Galaxy", 30){ Price = 4500m}
            //};

            Application.Run(new Login(store));
        }
    }
}