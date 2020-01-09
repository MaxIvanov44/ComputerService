namespace Database.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StatusMaster")]
    public partial class StatusMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_status { get; set; }

        [Required]
        [StringLength(50)]
        public string status { get; set; }
    }
}
