namespace Database.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Status
    {
        [Key]
        public int id_status { get; set; }

        [Column("status")]
        [Required]
        [StringLength(50)]
        public string status1 { get; set; }
    }
}
