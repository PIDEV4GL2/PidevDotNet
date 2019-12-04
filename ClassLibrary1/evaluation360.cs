namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pidevds.evaluation360")]
    public partial class evaluation360
    {
        [Key]
        [Column("id Eval360")]
        public int id_Eval360 { get; set; }

        public bool? etat { get; set; }

        [StringLength(30)]
        public string nameEvaluation { get; set; }

        public float? noteEvaluation { get; set; }

        [StringLength(30)]
        public string avisEvaluation { get; set; }
    }
}
