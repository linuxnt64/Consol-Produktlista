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
        /// Remove an item from the list
        /// </summary>
        void Delete(int _id);

        /// <summary>
        /// Put the object into the list
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

        /// <summary>
        /// Write a list into a file on a storage
        /// </summary>
        /// <param name="aFilePath"></param>
        /// <param name="aList"></param>
        void Stove(string aFilePath, List<ProductModel> aList);

        /// <summary>
        /// Read a file from a storage into a list
        /// </summary>
        /// <param name="aFilePath"></param>
        /// <param name="aList"></param>
        void Retrieve(string aFilePath, List<ProductModel> aList);

    }
}
