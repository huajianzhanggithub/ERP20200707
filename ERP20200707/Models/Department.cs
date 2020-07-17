using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP20200707.Data
{
    public partial class Department
    {
        public Department()
        {
            Warehouse = new HashSet<Warehouse>();
        }

        [Key]
        [Column("cDepCode")]
        [StringLength(12)]
        public string CDepCode { get; set; }
        [Column("bDepEnd")]
        public bool BDepEnd { get; set; }
        [Required]
        [Column("cDepName")]
        [StringLength(255)]
        public string CDepName { get; set; }
        [Column("iDepGrade")]
        public byte IDepGrade { get; set; }
        [Column("cDepPerson")]
        [StringLength(20)]
        public string CDepPerson { get; set; }
        [Column("cDepProp")]
        [StringLength(10)]
        public string CDepProp { get; set; }
        [Column("cDepPhone")]
        [StringLength(100)]
        public string CDepPhone { get; set; }
        [Column("cDepAddress")]
        [StringLength(255)]
        public string CDepAddress { get; set; }
        [Column("cDepMemo")]
        [StringLength(20)]
        public string CDepMemo { get; set; }
        [Column("iCreLine")]
        public double? ICreLine { get; set; }
        [Column("cCreGrade")]
        [StringLength(20)]
        public string CCreGrade { get; set; }
        [Column("iCreDate")]
        public int? ICreDate { get; set; }
        [Column("cOfferGrade")]
        [StringLength(20)]
        public string COfferGrade { get; set; }
        [Column("iOfferRate")]
        public double? IOfferRate { get; set; }
        [Column("pubufts")]
        public byte[] Pubufts { get; set; }
        [Required]
        [Column("bShop")]
        public bool? BShop { get; set; }
        [Column("cDepGUID")]
        public Guid CDepGuid { get; set; }
        [Column("dDepBeginDate", TypeName = "datetime")]
        public DateTime? DDepBeginDate { get; set; }
        [Column("dDepEndDate", TypeName = "datetime")]
        public DateTime? DDepEndDate { get; set; }
        [Column("vAuthorizeDoc")]
        [StringLength(50)]
        public string VAuthorizeDoc { get; set; }
        [Column("vAuthorizeUnit")]
        [StringLength(100)]
        public string VAuthorizeUnit { get; set; }
        [Column("cDepFax")]
        [StringLength(20)]
        public string CDepFax { get; set; }
        [Column("cDepPostCode")]
        [StringLength(6)]
        public string CDepPostCode { get; set; }
        [Column("cDepEmail")]
        [StringLength(100)]
        public string CDepEmail { get; set; }
        [Column("cDepType")]
        [StringLength(20)]
        public string CDepType { get; set; }
        [Column("bInheritDutyBasic")]
        public int? BInheritDutyBasic { get; set; }
        [Column("bInheritWorkCalendar")]
        public int? BInheritWorkCalendar { get; set; }
        [Column("cDutyCode")]
        [StringLength(50)]
        public string CDutyCode { get; set; }
        [Column("cRestCode")]
        [StringLength(50)]
        public string CRestCode { get; set; }
        [Column("bIM")]
        public bool? BIm { get; set; }
        [Column("cDepNameEn")]
        [StringLength(255)]
        public string CDepNameEn { get; set; }
        [Column("bRetail")]
        public bool? BRetail { get; set; }
        [Column("cDepFullName")]
        [StringLength(800)]
        public string CDepFullName { get; set; }
        [Column("iDepOrder")]
        public int? IDepOrder { get; set; }
        [Column("cDepLeader")]
        [StringLength(20)]
        public string CDepLeader { get; set; }
        [Column("dModifyDate", TypeName = "datetime")]
        public DateTime? DModifyDate { get; set; }
        [Column("cESpaceMembID")]
        [StringLength(50)]
        public string CEspaceMembId { get; set; }

        [InverseProperty("CDepCodeNavigation")]
        public virtual ICollection<Warehouse> Warehouse { get; set; }
    }
}
