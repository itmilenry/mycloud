﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace mycloud.Models
{
    public class VoltageClass
    {
        [Key]
        public int VoltageClassId { get; set;  }
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}