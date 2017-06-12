using AspNet.WebForms.Mvp.Mvp;
using System;
using System.Web.UI;
using System.Collections.Generic;
using AspNet.WebForms.Mvp.Products;
using System.Web.UI.WebControls;

namespace AspNet.WebForms.Mvp
{
    public partial class Default : Page, IProductListView
    {
        private readonly IProductListPresenter _productListPresenter;

        public Default()
        {
            _productListPresenter = new ProductListPresenter();
        }

        public void ShowError(string message)
        {
            ltlErrorMessage.Text = message;
        }

        public void ShowProducts(IList<Product> products)
        {
            gvProducts.DataSource = products;
            gvProducts.DataBind();
        }

        public void ShowProductTypeFilter()
        {
            var itemValues = Enum.GetValues(typeof(ProductType));
            var itemNames = Enum.GetNames(typeof(ProductType));

            ddlProductTypes.Items.Add(new ListItem("Select a type", (-1).ToString()));
            for (int i = 0; i <= itemNames.Length - 1; i++)
            {
                ListItem item = new ListItem(itemNames[i], itemValues.GetValue(i).ToString());
                ddlProductTypes.Items.Add(item);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            _productListPresenter.SetView(this);

            if (!IsPostBack)
                _productListPresenter.Initialize();
        }

        protected void ddlProductTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selection = ddlProductTypes.SelectedValue;

            if (selection == "-1")
                _productListPresenter.LoadProducts(null);
            else
            {
                var productType = (ProductType)Enum.Parse(typeof(ProductType), selection);
                _productListPresenter.LoadProducts(productType);
            }
        }
    }
}