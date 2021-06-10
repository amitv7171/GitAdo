using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using ProductBusinessLayer;
using Entities;

namespace ProductManagementSystem
{
    public class ProductPL
    {
        static void Main(string[] args)
        {
            ProductBL productBL = new ProductBL();
            int choice;
            do
            {
                DisplayManu();
                Console.WriteLine("Enter Your Choice");
                choice = int.Parse(Console.ReadLine());
                switch(choice)
                {

                    case 1:
                        Category category = AddCategory();
                        productBL.AddCategory(category);

                        break;
                    case 2:
                        Product product = AddProduct();
                        productBL.AddProduct(product);

                        break;
                    case 3:

                        List<Category> categories = productBL.ShowCategory();
                        DisplayCategories(categories);

                        break;

                    case 4:

                        List<Product> products = productBL.ShowProduct();
                        DisplayProductes(products);
                        break;

                    case 5:
                        
                        Console.WriteLine("Enter the product Id");
                        int id = int.Parse(Console.ReadLine());
                        
                        Product product1 = productBL.ShowSpecificProduct(id);
                        DisplaySpecificEmployee(product1);
                        break;

                    case 6:

                        Console.WriteLine("Enter the product Id");
                        int id1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter updated price");
                        int price = int.Parse(Console.ReadLine());
                        Product product2 = productBL.UpdateProduct(id1,price);
                        break;

                    case 7:
                        Console.WriteLine("Enter the product Id");
                        int id2 = int.Parse(Console.ReadLine());
                        Product product3 = productBL.DeleteProduct(id2);

                        break;

                         /*  Console.WriteLine("5. Display Data Based on Product Id");
            Console.WriteLine("6. Update Product Price on product Id");
            Console.WriteLine("7. Delete Product Based on Product id");*/

                }

            } while (choice!=8);

        }
       /// <summary>
       /// Method Will display all the specific employe
       /// </summary>
       /// <param name="obj"></param>
        static void DisplaySpecificEmployee(Product obj)
        {
            Console.WriteLine();
            Console.WriteLine("ProductId        :    " + obj.ProductId);
            Console.WriteLine("ProductName      :    " + obj.ProductName);
            Console.WriteLine("ProductPrice     :    " + obj.Price);
            Console.WriteLine("ProductCategoryId:    " + obj.CategoryId);
            Console.WriteLine();
        }
        /// <summary>
        /// It will display all the product details
        /// </summary>
        /// <param name="products"></param>
         static void DisplayProductes(List<Product> products)
        {
           foreach(var obj in products)
            {
                Console.WriteLine("ProductId        :    " + obj.ProductId);
                Console.WriteLine("ProductName      :    " + obj.ProductName);
                Console.WriteLine("ProductPrice     :    " + obj.Price);
                Console.WriteLine("ProductCategoryId:    " + obj.CategoryId);

            }
           // throw new NotImplementedException();
        }
        /// <summary>
        /// It will display all the category
        /// </summary>
        /// <param name="categories"></param>
        static void DisplayCategories(List<Category> categories)
        {

            foreach (var obj in categories)
            {
                Console.WriteLine("CategoryId        :    " + obj.CategoryId);
                Console.WriteLine("CategoryName      :    " + obj.CategoryName);
               

            }
            // throw new NotImplementedException();
        }
        /// <summary>
        /// It will display all the product
        /// </summary>
        /// <returns></returns>
         static Product AddProduct()
        {

            Console.WriteLine("Enter Product Id");
            int productId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Name");
            string productName = Console.ReadLine();
            Console.WriteLine("Enter Product Price");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Category Id");
            int categoryId = int.Parse(Console.ReadLine());
            Product product = new Product(productId,productName,price,categoryId);
            return product;
            // throw new NotImplementedException();
        }
        /// <summary>
        /// It will add the category
        /// </summary>
        /// <returns></returns>
        private static Category AddCategory()
        {
            Console.WriteLine("Enter the Category Id");
            int categoryId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Category Name");
            string categoryName = Console.ReadLine();
            Category category = new Category(categoryId,categoryName);
            return category;

            // throw new NotImplementedException();
        }
        /// <summary>
        /// The static display Menu
        /// </summary>
        static void DisplayManu()
        {


            Console.WriteLine("******************************************");
            Console.WriteLine("1. Insert Data into Category");
            Console.WriteLine("2. Insert Data into Product");
            Console.WriteLine("3. Display Data from Category");
            Console.WriteLine("4. Display Data from Product");
            Console.WriteLine("5. Display Data Based on Product Id");
            Console.WriteLine("6. Update Product Price on product Id");
            Console.WriteLine("7. Delete Product Based on Product id");
            Console.WriteLine("******************************************");
            //throw new NotImplementedException();
        }
    }
}
