using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProductDataLayer
{   
    public class ProductDL
    {
    /// <summary>
    /// In this method we are going to add the category details to the database
    /// </summary>
    /// <param name="category"></param>
        public void AddCategory(Category category)
        {
            SqlConnection connection = new SqlConnection("data source=.; database=product; integrated security=SSPI");
            SqlCommand cm = null;
            try
            {
               
                cm = new SqlCommand("insert into category(categoryId,categoryName) values(@categoryId,@categoryName)", connection);

                connection.Open();
                cm.Parameters.Clear();
                
                cm.Parameters.AddWithValue("@categoryId", category.CategoryId);
                cm.Parameters.AddWithValue("@categoryName", category.CategoryName);
                cm.ExecuteNonQuery();
                Console.WriteLine("\nCategory Inserted Succesfully\n");

            }
            catch (Exception e)
            {
                Console.WriteLine("Data not Inserted");
            }
            finally
            {
                connection.Close();
            }


            // throw new NotImplementedException();
        }
        /// <summary>
        /// UpdateProduct method is used to Update the product details
        /// </summary>
        /// <param name="id1"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        public Product UpdateProduct(int id1, int price)
        {

            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection("data source=.; database=product; integrated security=SSPI");
                SqlCommand cm = new SqlCommand("update productt set price=@price where productId=@id1", connection);
                cm.Parameters.AddWithValue("@price", price);
                cm.Parameters.AddWithValue("@id1", id1);
                connection.Open();
                cm.ExecuteNonQuery();
                Console.WriteLine("Data Updated Sucessflly");

            }

            catch (Exception e)
            {
                Console.WriteLine("Data not updated");
            }
            finally
            {
                connection.Close();
            }
            return null;


        }
        /// <summary>
        /// To get the details of particular or specific product
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product ShowSpecificProduct(int id)
        {
            Product product = new Product();
            SqlConnection connection = new SqlConnection("data source=.; database=product; integrated security=SSPI");
            SqlCommand cm = null;
            try
            {
                cm = new SqlCommand("select * from productt where (productId=@id)", connection);
                cm.Parameters.AddWithValue("@id", id);
                connection.Open();
                SqlDataReader sql = cm.ExecuteReader();
                while (sql.Read())
                {

                    product.ProductId = Convert.ToInt32(sql[0]);
                    product.ProductName = Convert.ToString(sql[1]);
                    product.Price = Convert.ToInt32(sql[2]);
                    product.CategoryId = Convert.ToInt32(sql[3]);


                }


            }
            catch (Exception e)
            {
                Console.WriteLine("Data not Displayed");
            }
            finally
            {
                connection.Close();
            }
            return product;



            // throw new NotImplementedException();
        }
        /// <summary>
        /// To delete the product, By passing the product Id
        /// </summary>
        /// <param name="id2"></param>
        /// <returns></returns>
        public Product DeleteProduct(int id2)
        {

            SqlConnection connection = new SqlConnection("data source=.; database=product; integrated security=SSPI");
            SqlCommand cm = null;
            try
            {
                cm = new SqlCommand("delete from productt where productId=@id2", connection);
                cm.Parameters.AddWithValue("@id2", id2);
                connection.Open();
                cm.ExecuteNonQuery();

                Console.WriteLine("Data Deleted Sucessflly");
            }
            catch (Exception e)
            {
                Console.WriteLine("Data not Deleted");
            }
            finally
            {
                connection.Close();
            }
            return null;



            //   throw new NotImplementedException();
        }
        /// <summary>
        /// To get the all details of the product
        /// </summary>
        /// <returns></returns>
        public List<Product> ShowProduct()
        {
            List<Product> products = new List<Product>();
            SqlConnection connection = new SqlConnection("data source=.; database=product; integrated security=SSPI");
            SqlCommand cm = null;
            try
            {
                cm = new SqlCommand("select * from productt", connection);

                connection.Open();
                SqlDataReader sql = cm.ExecuteReader();
                while (sql.Read())
                {
                    Product product = new Product();
                    product.ProductId = Convert.ToInt32(sql[0]);
                    product.ProductName = Convert.ToString(sql[1]);
                    product.Price = Convert.ToInt32(sql[2]);
                    product.CategoryId = Convert.ToInt32(sql[3]);
                    products.Add(product);



                }
                sql.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Data not Displayed");
            }
            finally
            {  
                connection.Close();
            }

            return products;
            // throw new NotImplementedException();
        }
        /// <summary>
        /// To get the all the details of Category
        /// </summary>
        /// <returns></returns>
        public List<Category> ShowCategory()
        {
            List<Category> categories = new List<Category>();
            SqlConnection connection = new SqlConnection("data source=.; database=product; integrated security=SSPI");
            SqlCommand cm = null;
            try
            {
                cm = new SqlCommand("select * from category", connection);

                connection.Open();
                SqlDataReader sql = cm.ExecuteReader();
                while (sql.Read())
                {
                    Category category = new Category();
                    category.CategoryId = Convert.ToInt32(sql[0]);
                    category.CategoryName = Convert.ToString(sql[1]);
                    categories.Add(category);

                }


            }
            catch (Exception e)
            {
                Console.WriteLine("Data not Displayed");
            }
            finally
            {
                connection.Close();
            }

            return categories;


            //throw new NotImplementedException();
        }
        /// <summary>
        /// To add the product in the database
        /// </summary>
        /// <param name="product"></param>
        public void AddProduct(Product product)
        {

            SqlConnection connection = new SqlConnection("data source=.; database=product; integrated security=SSPI");
            SqlCommand cm = null;
            try
            {
                cm = new SqlCommand("insert into productt(productId,productName,price,categoryId) values(@productId,@productName,@price,@categoryId)", connection);

                connection.Open();
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@productId", product.ProductId);
                cm.Parameters.AddWithValue("@productName", product.ProductName);
                cm.Parameters.AddWithValue("@price", product.Price);
                cm.Parameters.AddWithValue("@categoryId", product.CategoryId);

                cm.ExecuteNonQuery();
                Console.WriteLine("\nProduct Inserted Succesfully\n");

            }
            catch (Exception e)
            {
                Console.WriteLine("Data not Inserted");
            }
            finally
            {
                connection.Close();
            }


            // throw new NotImplementedException();
        }
    }
}
