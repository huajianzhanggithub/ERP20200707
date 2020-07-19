using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP20200707.Models
{
    public partial class TjgCgjg
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [Column("ccode")]
        [StringLength(30)]
        public string Ccode { get; set; }
        [Column("whcode")]
        [StringLength(50)]
        public string Whcode { get; set; }
        [Column("cgrq", TypeName = "datetime")]
        public DateTime? Cgrq { get; set; }
        [Column("cWhName")]
        [StringLength(20)]
        public string CWhName { get; set; }
        [Column("cInvName")]
        [StringLength(255)]
        public string CInvName { get; set; }
        [Column("cInvStd")]
        [StringLength(255)]
        public string CInvStd { get; set; }
        [Column("iquantity")]
        public double? Iquantity { get; set; }
        [Column("iprice")]
        public double? Iprice { get; set; }
        [Column("iunitcost")]
        public double? Iunitcost { get; set; }
        [Required]
        [Column("lccode")]
        [StringLength(30)]
        public string Lccode { get; set; }
        [Column("liunitcost")]
        public double? Liunitcost { get; set; }
    }
}
