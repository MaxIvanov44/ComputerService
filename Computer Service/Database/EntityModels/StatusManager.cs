namespace Database.EntityModels
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("StatusManager")]
    public partial class StatusManager
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_status { get; set; }

        [Required]
        [StringLength(50)]
        public string status { get; set; }
    }
}