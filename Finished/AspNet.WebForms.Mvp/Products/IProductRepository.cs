using System.Collections.Generic;

namespace AspNet.WebForms.Mvp.Products
{
    public interface IProductRepository
    {
        IList<Product> GetAll();

        IList<Product> GetByProductType(ProductType productType);
    }

}
