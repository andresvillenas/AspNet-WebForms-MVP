using AspNet.WebForms.Mvp.Base;
using AspNet.WebForms.Mvp.Products;

namespace AspNet.WebForms.Mvp.Mvp
{
    public interface IProductListPresenter : IPresenter<IProductListView>
    {
        void LoadProducts(ProductType? productTypeSelected);
    }
}
