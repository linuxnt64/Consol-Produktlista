using Exercise3.Interfaces;
using Exercise3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Interfaces
{
    internal interface IListHandler
    {

        /// <summary>
        /// Read the indexed item from list into the object Product
        /// </summary>
        void Retrieve(int index);

        /// <summary>
        /// Remove an item from the list
        /// </summary>
        void Delete(int _id);

        /// <summary>
        /// Put the object product into the list
        /// </summary>
        void Write(ProductModel anItem, List<ProductModel> aList);

        /// <summary>
        /// 
        /// </summary>
        int FindItem(string _searcher);

        /// <summary>
        /// Show all items in the list
        /// </summary>
        void Print(ProductModel anItem, List<ProductModel> aList);
    }
}
