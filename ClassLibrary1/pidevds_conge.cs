namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pidevds.[pidevds.conge]")]
    public partial class pidevds_conge
    {
        [Key]
        public int idConge { get; set; }

        public DateTime? dateDeb { get; set; }

        public DateTime? dateFin { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public int? user_idUser { get; set; }
    }
}
