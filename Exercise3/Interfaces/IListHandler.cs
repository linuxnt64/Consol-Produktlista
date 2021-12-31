using Exercise3.Interfaces;
using Exercise3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Interfaces
{
    public interface IListHandler
    {

        /// <summary>
        /// Put an object into a list
        /// </summary>
        /// <param name="anItem"></param>
        /// <param name="aList"></param>
        void Write(ProductModel anItem, List<ProductModel> aList);

        /// <summary>
        /// Show all items in a list
        /// </summary>
        /// <param name="aList"></param>
        void Print(List<ProductModel> aList);

        /// <summary>
        /// Looks up an item in a list by id
        /// </summary>
        /// <param name="aList"></param>
        /// <param name="searchterm"></param>
        /// <returns>Item<ProductModel></returns>
        extern ProductModel FindItem(List<ProductModel> aList, string searchterm);

        /// <summary>
        /// Remove an item from a list by id
        /// </summary>
        /// <param name="aList"></param>
        /// <param name="searchterm"></param>
        extern void Delete(List<ProductModel> aList, string searchterm);
    }
}
