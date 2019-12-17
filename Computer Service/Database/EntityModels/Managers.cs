namespace Database.EntityModels
{
    using System.ComponentModel.DataAnnotations;

    public partial class Managers
    {
        [Key]
        public int id_manager { get; set; }

        [Required]
        [StringLength(50)]
        public string username { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }

        [Required]
        [StringLength(50)]
        public string first_name { get; set; }

        [Required]
        [StringLength(50)]
        public string last_name { get; set; }

        [Required]
        [StringLength(50)]
        public string middle_name { get; set; }

        [Required]
        [StringLength(100)]
        public string address { get; set; }

        [Required]
        [StringLength(4)]
        public string serial_passport { get; set; }

        [Required]
        [StringLength(6)]
        public string number_passport { get; set; }

        [Required]
        [StringLength(50)]
        public string phone { get; set; }

        [Required]
        [StringLength(50)]
        public string email { get; set; }
    }
}