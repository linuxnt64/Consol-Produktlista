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
        /// Tries to save the list of products to a file and returns a boolean result
        /// </summary>
        /// <param name="List"></param>
        /// <param name="fullFilePathAndName"></param>
        extern static bool SaveToDisk(List<ProductModel> List, string fullFilePathAndName);

        /// <summary>
        /// Tries to read the list of products from a file and returns a boolean result
        /// </summary>
        /// <param name="List"></param>
        /// <param name="fullFilePathAndName"></param>
        /// <returns></returns>
        extern static bool ReadFromDisk(List<ProductModel> List, string fullFilePathAndName);
    }
}
