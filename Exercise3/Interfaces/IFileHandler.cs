using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Exercise3.Models;

namespace Exercise3.Interfaces
{
    public interface IFileHandler
    {
        /// <summary>
        /// Saves a list of products to a file
        /// </summary>
        /// <param name="path"></param>
        /// <param name="TheList"></param>
        extern static void Stowe(string path, List<ProductModel> TheList);

        /// <summary>
        /// Tries to read the list of products from a file and returns a boolean result
        /// </summary>
        /// <param name="List"></param>
        /// <param name="fullFilePathAndName"></param>
        /// <returns></returns>
        extern static List<ProductModel> Retrieve(string path);
    }
}
