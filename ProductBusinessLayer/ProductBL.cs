using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductDataLayer;

namespace ProductBusinessLayer
{
    public class ProductBL
    {
        ProductDL productDL = new ProductDL();
        public void AddCategory(Category category)
        {
            productDL.AddCategory(category);
            //throw new NotImplementedException();
        }

        public void AddProduct(Product product)
        {
            productDL.AddProduct(product);
           // throw new NotImplementedException();
        }

        public List<Category> ShowCategory()
        {
            return productDL.ShowCategory();
           // throw new NotImplementedException();
        }

        public List<Product> ShowProduct()
        {
            return productDL.ShowProduct();
            //throw new NotImplementedException();
        }

        public Product ShowSpecificProduct(int id)
        {
            return productDL.ShowSpecificProduct(id);
           // throw new NotImplementedException();
        }

        public Product UpdateProduct(int id1, int price)
        {
            return productDL.UpdateProduct(id1,price);
           // throw new NotImplementedException();
        }

        public Product DeleteProduct(int id2)
        {
            return productDL.DeleteProduct(id2);
          //  throw new NotImplementedException();
        }
    }
}
