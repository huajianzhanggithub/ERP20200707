using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP20200707.Data
{
    public partial class InventoryClass
    {
        public InventoryClass()
        {
            Inventory = new HashSet<Inventory>();
        }

        [Key]
        [Column("cInvCCode")]
        [StringLength(12)]
        public string CInvCcode { get; set; }
        [Column("cInvCName")]
        [StringLength(100)]
        public string CInvCname { get; set; }
        [Column("iInvCGrade")]
        public byte IInvCgrade { get; set; }
        [Column("bInvCEnd")]
        public bool? BInvCend { get; set; }
        [Column("cEcoCode")]
        [StringLength(2)]
        public string CEcoCode { get; set; }
        [Column("cBarCode")]
        [StringLength(30)]
        public string CBarCode { get; set; }
        [Column("pubufts")]
        public byte[] Pubufts { get; set; }

        [InverseProperty("CInvCcodeNavigation")]
        public virtual ICollection<Inventory> Inventory { get; set; }
    }
}
