using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Course.Models
{
    public class ProductCreationVM
    {
        [Required(ErrorMessage = "請填寫商品名稱")]
        [StringLength(10, ErrorMessage = "商品名稱長度不得超過 10 個字元")]
        public string ProductName { get; set; }

        [Required]
        public Nullable<decimal> Price { get; set; }
    }
}