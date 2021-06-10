using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 create database product

create table category(categoryId int not null primary key,categoryName varchar(20));

*/

namespace Entities
{
  
    public class Product
    {
        int _productId;
        string _productName;
        int _price;
        int _categoryId;

        public Product()
        {


        }
        public Product(int productId, string productName, int price, int categoryId)
        {
            _productId = productId;
            _productName = productName;
            _price = price;
            _categoryId = categoryId;
        }

        public int ProductId { get => _productId; set => _productId = value; }
        public string ProductName { get => _productName; set => _productName = value; }
        public int Price { get => _price; set => _price = value; }
        public int CategoryId { get => _categoryId; set => _categoryId = value; }
    }
}
