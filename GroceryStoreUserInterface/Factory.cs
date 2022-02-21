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
                case "IStore":
                    return new Store();
                default:
                    return null;
            }

        }

    }
}
