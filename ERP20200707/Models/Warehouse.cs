using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP20200707.Models
{
    public partial class Warehouse
    {
        [Key]
        [Column("cWhCode")]
        [StringLength(10)]
        public string CWhCode { get; set; }
        [Column("cWhName")]
        [StringLength(20)]
        public string CWhName { get; set; }
        [Column("cDepCode")]
        [StringLength(12)]
        public string CDepCode { get; set; }
        [Column("cWhAddress")]
        [StringLength(255)]
        public string CWhAddress { get; set; }
        [Column("cWhPhone")]
        [StringLength(100)]
        public string CWhPhone { get; set; }
        [Column("cWhPerson")]
        [StringLength(10)]
        public string CWhPerson { get; set; }
        [Required]
        [Column("cWhValueStyle")]
        [StringLength(12)]
        public string CWhValueStyle { get; set; }
        [Column("bWhPos")]
        public bool BWhPos { get; set; }
        [Column("iWhFundQuota")]
        public double? IWhFundQuota { get; set; }
        [Column("cMonth")]
        [StringLength(6)]
        public string CMonth { get; set; }
        [Column("cWhMemo")]
        [StringLength(20)]
        public string CWhMemo { get; set; }
        [Required]
        [Column("bFreeze")]
        public bool? BFreeze { get; set; }
        [Column("cBarCode")]
        [StringLength(30)]
        public string CBarCode { get; set; }
        [Required]
        [Column("bMRP")]
        public bool? BMrp { get; set; }
        [Column("pubufts")]
        public byte[] Pubufts { get; set; }
        [Required]
        [Column("bROP")]
        public bool? BRop { get; set; }
        [Column("iFrequency")]
        public short? IFrequency { get; set; }
        [Column("cFrequency")]
        [StringLength(10)]
        public string CFrequency { get; set; }
        [Column("iDays")]
        public short? IDays { get; set; }
        [Column("dLastDate", TypeName = "datetime")]
        public DateTime? DLastDate { get; set; }
        [Column("iWHProperty")]
        public short IWhproperty { get; set; }
        [Required]
        [Column("bShop")]
        public bool? BShop { get; set; }
        [Required]
        [Column("bControlSerial")]
        public bool? BControlSerial { get; set; }
        [Required]
        [Column("bInCost")]
        public bool? BInCost { get; set; }
        [Required]
        [Column("bInAvailCalcu")]
        public bool? BInAvailCalcu { get; set; }
        [Required]
        [Column("bProxyWh")]
        public bool? BProxyWh { get; set; }
        [Column("iSAConMode")]
        public short ISaconMode { get; set; }
        [Column("iEXConMode")]
        public short IExconMode { get; set; }
        [Column("iSTConMode")]
        public short IStconMode { get; set; }
        [Required]
        [Column("bBondedWh")]
        public bool? BBondedWh { get; set; }
        [Required]
        [Column("bWhAsset")]
        public bool? BWhAsset { get; set; }
        [Column("fWhQuota")]
        public double? FWhQuota { get; set; }
        [Column("dWhEndDate", TypeName = "datetime")]
        public DateTime? DWhEndDate { get; set; }
        [Column("bCheckSubitemCost")]
        public bool? BCheckSubitemCost { get; set; }
        [Column("cPickPos")]
        [StringLength(40)]
        public string CPickPos { get; set; }
        [Column("bEB")]
        public bool? BEb { get; set; }
        [Column("dModifyDate", TypeName = "datetime")]
        public DateTime? DModifyDate { get; set; }
        [Column("cWareGroupCode")]
        [StringLength(100)]
        public string CWareGroupCode { get; set; }
        [Column("cProvince")]
        [StringLength(100)]
        public string CProvince { get; set; }
        [Column("cCity")]
        [StringLength(100)]
        public string CCity { get; set; }
        [Column("cCounty")]
        [StringLength(100)]
        public string CCounty { get; set; }

        [ForeignKey(nameof(CDepCode))]
        [InverseProperty(nameof(Department.Warehouse))]
        public virtual Department CDepCodeNavigation { get; set; }
    }
}
