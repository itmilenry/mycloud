using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mycloud.Models
{
    public class Installation3
    {
        [Key]
        public int Installation3Id { get; set;  }
        public string Description { get; set; }

    }
}