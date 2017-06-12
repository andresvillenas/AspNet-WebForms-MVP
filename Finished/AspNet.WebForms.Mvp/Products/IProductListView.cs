using AspNet.WebForms.Mvp.Base;
using System.Collections.Generic;

namespace AspNet.WebForms.Mvp.Products
{
    public interface IProductListView : IView
    {
        void ShowProductTypeFilter();

        void ShowProducts(IList<Product> products);
    }
}
