using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mycloud.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string CommercialName { get; set; }
        public string Image { get; set; }
        public string GenericName { get; set; }
        public string CatalogueAddress { get; set; }
        public string Translation { get; set; }

        public int InsulatorId { get; set; }
        public virtual Insulator Insulator { get; set; }

        public int ConductorId { get; set; }
        public virtual Conductor Conductor { get; set; }
        
        public int DesignId { get; set; }
        public virtual Design Design { get; set; }


        public int RestrictionId { get; set; }
        public virtual Restriction Restriction { get; set; }
        
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }


        public int CprClassId { get; set; }
        public virtual CprClass CprClass { get; set; }

        
        public int VoltageClassId { get; set; }
        public virtual VoltageClass VoltageClass { get; set; }

        public int CableRangeId { get; set; }
        public virtual CableRange CableRange { get; set; }

        public int Position {get;set;}
        public bool IsArmoured {get; set;}
    }
}