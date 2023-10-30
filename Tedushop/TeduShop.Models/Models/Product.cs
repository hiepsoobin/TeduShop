using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Models.Models
{
    [Table("Products")]
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
            
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public int ProductCategoryId { get; set; }
            
        public int ProductCategoryName { get; set; }
        public int ProductCategoryDescription { get; set;}
    }
    }
    }
}
