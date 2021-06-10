using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Category
    {
        int categoryId;
        string categoryName;

        public Category()
        {


        }
        public Category(int categoryId, string categoryName)
        {
            this.categoryId = categoryId;
            this.categoryName = categoryName;
        }

        public int CategoryId { get => categoryId; set => categoryId = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
    }
}
