﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Exercise3.Interfaces;
using Exercise3.Models;


namespace Exercise3.Handlers
{
    public class FileHandler
    {
        public static void Stowe(string path, List<ProductModel> TheList)
        {
            Console.WriteLine("Writing data to: " + path);
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(JsonConvert.SerializeObject(TheList));
                Console.ReadKey();
            }

        }

        public static List<ProductModel> Retrieve(string path)
        {
            Console.WriteLine("Reading data from: " + path);
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string data = sr.ReadToEnd();
                    //Console.WriteLine(data);
                    return JsonConvert.DeserializeObject<List<ProductModel>>(data);
                    Console.WriteLine("Klart: (Har läst data från fil)");
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