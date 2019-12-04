namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pidevds.formation")]
    public partial class formation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public formation()
        {
            user = new HashSet<user>();
        }

        [Key]
        public int idFormation { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(255)]
        public string categories { get; set; }

        public DateTime? date { get; set; }

        public int niveau_in { get; set; }

        public int niveau_out { get; set; }

        [StringLength(255)]
        public string nom { get; set; }

        [StringLength(255)]
        public string nomFormateur { get; set; }

        public int? type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user> user { get; set; }
    }
}
