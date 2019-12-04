namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pidevds.[pidevds.user]")]
    public partial class pidevds_user
    {
        [Key]
        public int idUser { get; set; }

        [StringLength(255)]
        public string Firstname { get; set; }

        [StringLength(255)]
        public string Lastname { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [Column(TypeName = "bit")]
        public bool? isActiv { get; set; }

        [StringLength(255)]
        public string password { get; set; }

        [StringLength(255)]
        public string role { get; set; }
    }
}
