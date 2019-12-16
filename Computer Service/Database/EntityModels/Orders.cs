namespace Database.EntityModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Orders
    {
        [Key]
        public int id_order { get; set; }

        public int order_status { get; set; }

        public int client { get; set; }

        public int master { get; set; }

        public int computer { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_of_acceptance { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_of_return { get; set; }

        public int? repair_price { get; set; }

        [StringLength(100)]
        public string description { get; set; }

        public virtual Clients Clients { get; set; }

        public virtual Computers Computers { get; set; }

        public virtual Masters Masters { get; set; }

        public virtual Status Status { get; set; }
    }
}