using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Exercise3.Interfaces;
using Exercise3.Models;


namespace Exercise3.Handlers
{
    public class FileHandler : IFileHandler
    {
        public void Stowe(string path, List<ProductModel> TheList)
        {
            try
            {
                Console.WriteLine("Writing data to: " + path);
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(JsonConvert.SerializeObject(TheList));
                }
            }
            catch
            {
                Console.WriteLine("\t¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤\n" +
                                  "\t¤¤¤¤¤¤  FEL:  Det gick inte att skriva till fil. Är sökvägen riktig ?  ¤¤¤¤¤¤\n" +
                                 $"\t{path}\n" +
                                  "\t¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
            }

        }

        public List<ProductModel> Retrieve(string path)
        {
            Console.WriteLine("Reading data from: " + path);
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string data = sr.ReadToEnd();
                    Console.WriteLine("Klart: (Har läst data från fil)");
                    return JsonConvert.DeserializeObject<List<ProductModel>>(data);
                }

            }
            catch
            {
                Console.WriteLine("\t¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤\n" +
                                  "\t¤¤¤¤¤¤  FEL:  Det gick inte att läsa in från fil. Filen kanske saknas?  ¤¤¤¤¤¤\n" +
                                  "\t¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
                return null;
            }
        }
    }
}
