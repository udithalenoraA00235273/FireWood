using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FireWood.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductPicture { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public string ProductDesc { get; set; }
    }
}
