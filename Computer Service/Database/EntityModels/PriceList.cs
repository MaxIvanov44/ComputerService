namespace Database.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PriceList")]
    public partial class PriceList
    {
        [Key]
        public int id_service { get; set; }

        [Required]
        [StringLength(255)]
        public string service { get; set; }

        public double? price_from { get; set; }

        public double? price_up { get; set; }
    }
}
