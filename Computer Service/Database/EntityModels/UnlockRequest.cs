namespace Database.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UnlockRequest")]
    public partial class UnlockRequest
    {
        [Key]
        public int id_request { get; set; }

        public int client { get; set; }

        [Required]
        [StringLength(200)]
        public string message { get; set; }
    }
}
