namespace MVC5Course.Models
{
    using MVC5Course.Models.DataTypeAttributes;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(ProductMetaData))]
    public partial class Product
    {
    }
    
    public partial class ProductMetaData
    {
        public int ProductId { get; set; }
        
        [Required]
        [StringLength(80, ErrorMessage="欄位長度不得大於 80 個字元")]
        [ValidateTaiwanAddress]
        public string ProductName { get; set; }
        [Required]
        public Nullable<decimal> Price { get; set; }
        [Required]
        public Nullable<bool> Active { get; set; }
        [Required]
        public Nullable<decimal> Stock { get; set; }
    
        public virtual ICollection<OrderLine> OrderLine { get; set; }
    }
}
