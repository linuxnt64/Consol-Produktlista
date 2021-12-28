using Exercise3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Interfaces
{ 
    public interface IProductHandler
    {
        /// <summary>
        /// Prepare to retrieve an item from the list
        /// </summary>
        void Peek();

        /// <summary>
        /// Prepare to put a new item into the list by populating object fields
        /// </summary>
        void Poke(ProductModel SomeProduct);

        /// <summary>
        /// Clean item object 
        /// </summary>
        void Purge();
    }
}
