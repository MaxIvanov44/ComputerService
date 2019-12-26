namespace Database.EntityModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Computers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Computers()
        {
            Orders = new HashSet<Orders>();
        }

        [Key]
        public int id_comp { get; set; }

        [Required]
        [StringLength(100)]
        public string problem { get; set; }

        [Required]
        [StringLength(50)]
        public string brand { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [StringLength(100)]
        public string model { get; set; }

        [StringLength(200)]
        public string description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
    }
}