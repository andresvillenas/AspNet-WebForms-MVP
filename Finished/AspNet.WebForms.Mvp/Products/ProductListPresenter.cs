using AspNet.WebForms.Mvp.Products;

namespace AspNet.WebForms.Mvp.Mvp
{
    public class ProductListPresenter : IProductListPresenter
    {
        private IProductListView _view;

        private IProductRepository _productRepository;

        public ProductListPresenter()
        {
            _productRepository = new ProductRepository();
        }

        public void Initialize()
        {
            _view.ShowProductTypeFilter();
            LoadAllProducts();
        }

        public void LoadProducts(ProductType? productTypeSelected)
        {
            if (productTypeSelected.HasValue)
            {
                var products = _productRepository.GetByProductType(productTypeSelected.Value);
                _view.ShowProducts(products);
            }
            else
                LoadAllProducts();
        }

        public void SetView(IProductListView view)
        {
            _view = view;
        }

        private void LoadAllProducts()
        {
            var products = _productRepository.GetAll();
            _view.ShowProducts(products);
        }
    }
}
