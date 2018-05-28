using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mycloud.Models
{
    public class LinkCableInstallation
    {
        [Key]
        public int LinkCableInstallationId { get; set;  }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int Installation1Id { get; set; }
        public virtual Installation1 Installation1 { get; set; }

        public int Installation2Id { get; set; }
        public virtual Installation2 Installation2 { get; set; }

        public int Installation3Id { get; set; }
        public virtual Installation3 Installation3 { get; set; }       

    }
}