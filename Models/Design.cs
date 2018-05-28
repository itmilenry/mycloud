using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mycloud.Models
{
    public class Design
    {
        [Key]
        public int DesignId { get; set;  }
        public string Description { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}