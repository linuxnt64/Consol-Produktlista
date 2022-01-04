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
        /// <param name="SomeList"></param>
        void Peek(List<ProductModel> SomeList);

        /// <summary>
        /// Prepare to put a new item into the list by populating object fields
        /// </summary>
        /// <param name="SomeProduct"></param>

        void Poke(List<ProductModel> SomeList);

        /// <summary>
        /// Clean item object 
        /// </summary>
        /// <param name="SomeList"></param>
        void Purge(List<ProductModel> SomeList);
    }
}
