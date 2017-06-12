using System;

namespace AspNet.WebForms.Mvp.Products
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ProductType ProductType { get; set; }
    }
}