namespace Database.EntityModels
{
    using System.ComponentModel.DataAnnotations;

    public partial class Computers
    {
        [Key]
        public int id_comp { get; set; }

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

        [StringLength(50)]
        public string price { get; set; }

        [StringLength(200)]
        public string description { get; set; }
    }
}