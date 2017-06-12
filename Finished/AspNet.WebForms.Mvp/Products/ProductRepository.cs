using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace AspNet.WebForms.Mvp.Products
{
    public class ProductRepository : IProductRepository
    {
        public IList<Product> GetAll()
        {
            var dataDirectory = AppDomain.CurrentDomain.GetData("DataDirectory"); ;//anywhere
            using (StreamReader file = File.OpenText($"{dataDirectory.ToString()}/Data.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                return (IList<Product>)serializer.Deserialize(file, typeof(List<Product>));
            }
        }

        public IList<Product> GetByProductType(ProductType productType)
        {
            return GetAll().Where(p => p.ProductType == productType).ToList();
        }
    }
}