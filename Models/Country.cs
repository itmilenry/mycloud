using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mycloud.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set;  }
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
        public virtual ICollection<Design> Designs { get; set; } = new List<Design>();
        public virtual ICollection<CableRange> CableRanges { get; set; } = new List<CableRange>();
    }
}