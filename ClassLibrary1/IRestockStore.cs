using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    [Document("This is an interface for RestockStore", Input = "int newProduct", Output = "none")]
    internal interface IRestockStore
    {
        void RestockStore(int newProduct);
    }
}
