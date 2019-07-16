using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ipt2project.Models
{
    public class Products
    {
        [Key]
        public int product_id { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string product_name { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string product_type { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string quantity { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string price { get; set; }
    }
}