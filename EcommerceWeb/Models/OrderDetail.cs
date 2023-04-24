using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceWeb.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        [Required] 
        public int OrderHeaderId { get; set; }
        //public OrderHeader OrderHeader { get; set; }

        [Required]
        public int CustomerId { get; set; }
        public int ProductId { get; set; }

        public int Count { get; set; }
        public double Price { get; set; }
    }
}
