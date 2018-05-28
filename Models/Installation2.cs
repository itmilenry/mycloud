using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mycloud.Models
{
    public class Installation2
    {
        [Key]
        public int Installation2Id { get; set;  }
        public string Description { get; set; }

    }
}