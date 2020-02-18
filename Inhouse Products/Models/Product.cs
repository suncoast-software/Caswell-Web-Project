using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Inhouse_Products.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public int UserId { get; set; }

        [Required]
        [StringLength(255)]
        public string ProductName { get; set; }

        [StringLength(1000)]
        public string Desc { get; set; }

        [StringLength(1000)]
        public Uri ProductUrl { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public bool InStock { get; set; }

        public DateTime ExpectedDelivery { get; set; }

        public ProductStatus Status { get; set; }

        public byte[] ImageContent { get; set; }

    }
}
