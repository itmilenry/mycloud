using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mycloud.Models
{
    public class Installation1
    {
        [Key]
        public int Installation1Id { get; set;  }
        public string Description { get; set; }

    }
}