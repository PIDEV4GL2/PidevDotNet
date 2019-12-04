namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pidevds.[pidevds.evaluation]")]
    public partial class pidevds_evaluation
    {
        public int id { get; set; }

        public DateTime? DateEval { get; set; }

        public double? MoyenneNote { get; set; }

        [StringLength(255)]
        public string critere { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string notation { get; set; }

        public int? noteA { get; set; }

        public int? noteB { get; set; }

        [StringLength(255)]
        public string typeEval { get; set; }

        public int? employe_idUser { get; set; }
    }
}
