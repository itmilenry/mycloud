using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mycloud.Models
{
    public class CableRange
    {
        [Key]
        public int CableRangeId { get; set;  }
        public string Description { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}