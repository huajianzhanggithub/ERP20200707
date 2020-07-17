using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP20200707.Data
{
    [Table("tjg_cgdj")]
    public partial class TjgCgdj
    {
        [Column("autoid")]
        public int? Autoid { get; set; }
        [Column("id")]
        public int? Id { get; set; }
        [Column("whcode")]
        [StringLength(50)]
        public string Whcode { get; set; }
        [Column("cgrq", TypeName = "datetime")]
        public DateTime? Cgrq { get; set; }
        [Required]
        [Column("cinvcode")]
        [StringLength(50)]
        public string Cinvcode { get; set; }
        [Column("iunitcost")]
        public double? Iunitcost { get; set; }
        [Column("iquantity")]
        public double? Iquantity { get; set; }
        [Column("iprice")]
        public double? Iprice { get; set; }
        [Column("lautoid")]
        public int? Lautoid { get; set; }
        [Column("lid")]
        public int? Lid { get; set; }
        [Column("liunitcost")]
        public double? Liunitcost { get; set; }
        [Key]
        [Column("primaryid")]
        public int Primaryid { get; set; }
    }
}
