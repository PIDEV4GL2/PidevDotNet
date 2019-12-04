namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pidevds.[pidevds.contrat]")]
    public partial class pidevds_contrat
    {
        [Key]
        public int idContrat { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateDebut { get; set; }

        public float salaire { get; set; }

        [StringLength(255)]
        public string typeContrat { get; set; }

        public int? user_idUser { get; set; }
    }
}
