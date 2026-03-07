using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEFDemo.Models
{
     class Category
    {
        public int Id { set; get; } // this will create identity column in table 
        public string Name { set; get; }

        public List<Product> Products { set; get; }
    }
}
