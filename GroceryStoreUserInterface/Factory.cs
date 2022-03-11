using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroceryStore;

namespace GroceryStoreUserInterface
{
    public static class Factory
    {

        public static object GenerateDI(string nameOf)
        {
            switch (nameOf)
            {
                case "Store":
                    return new Store();
                    
                case "Data":
                    return new Database();
                    
                default:
                    return null;
            }

        }

    }
}
