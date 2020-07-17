using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP20200707.Data
{
    public partial class RdRecord01
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }
        [Column("bRdFlag")]
        public byte BRdFlag { get; set; }
        [Required]
        [Column("cVouchType")]
        [StringLength(2)]
        public string CVouchType { get; set; }
        [Column("cBusType")]
        [StringLength(12)]
        public string CBusType { get; set; }
        [Required]
        [Column("cSource")]
        [StringLength(50)]
        public string CSource { get; set; }
        [Column("cBusCode")]
        [StringLength(30)]
        public string CBusCode { get; set; }
        [Required]
        [Column("cWhCode")]
        [StringLength(10)]
        public string CWhCode { get; set; }
        [Column("dDate", TypeName = "datetime")]
        public DateTime DDate { get; set; }
        [Required]
        [Column("cCode")]
        [StringLength(30)]
        public string CCode { get; set; }
        [Column("cRdCode")]
        [StringLength(5)]
        public string CRdCode { get; set; }
        [Column("cDepCode")]
        [StringLength(12)]
        public string CDepCode { get; set; }
        [Column("cPersonCode")]
        [StringLength(20)]
        public string CPersonCode { get; set; }
        [Column("cPTCode")]
        [StringLength(2)]
        public string CPtcode { get; set; }
        [Column("cSTCode")]
        [StringLength(2)]
        public string CStcode { get; set; }
        [Column("cCusCode")]
        [StringLength(20)]
        public string CCusCode { get; set; }
        [Column("cVenCode")]
        [StringLength(20)]
        public string CVenCode { get; set; }
        [Column("cOrderCode")]
        [StringLength(30)]
        public string COrderCode { get; set; }
        [Column("cARVCode")]
        [StringLength(30)]
        public string CArvcode { get; set; }
        [Column("cBillCode")]
        public long? CBillCode { get; set; }
        [Column("cDLCode")]
        public long? CDlcode { get; set; }
        [Column("cProBatch")]
        [StringLength(60)]
        public string CProBatch { get; set; }
        [Column("cHandler")]
        [StringLength(20)]
        public string CHandler { get; set; }
        [Column("cMemo")]
        [StringLength(255)]
        public string CMemo { get; set; }
        [Required]
        [Column("bTransFlag")]
        public bool? BTransFlag { get; set; }
        [Column("cAccounter")]
        [StringLength(20)]
        public string CAccounter { get; set; }
        [Column("cMaker")]
        [StringLength(20)]
        public string CMaker { get; set; }
        [Column("cDefine1")]
        [StringLength(20)]
        public string CDefine1 { get; set; }
        [Column("cDefine2")]
        [StringLength(20)]
        public string CDefine2 { get; set; }
        [Column("cDefine3")]
        [StringLength(20)]
        public string CDefine3 { get; set; }
        [Column("cDefine4", TypeName = "datetime")]
        public DateTime? CDefine4 { get; set; }
        [Column("cDefine5")]
        public int? CDefine5 { get; set; }
        [Column("cDefine6", TypeName = "datetime")]
        public DateTime? CDefine6 { get; set; }
        [Column("cDefine7")]
        public double? CDefine7 { get; set; }
        [Column("cDefine8")]
        [StringLength(4)]
        public string CDefine8 { get; set; }
        [Column("cDefine9")]
        [StringLength(8)]
        public string CDefine9 { get; set; }
        [Column("cDefine10")]
        [StringLength(60)]
        public string CDefine10 { get; set; }
        [Column("dKeepDate")]
        [StringLength(5)]
        public string DKeepDate { get; set; }
        [Column("dVeriDate", TypeName = "datetime")]
        public DateTime? DVeriDate { get; set; }
        [Column("bpufirst")]
        public bool? Bpufirst { get; set; }
        [Column("biafirst")]
        public bool? Biafirst { get; set; }
        [Column("iMQuantity")]
        public double? IMquantity { get; set; }
        [Column("dARVDate", TypeName = "datetime")]
        public DateTime? DArvdate { get; set; }
        [Column("cChkCode")]
        [StringLength(30)]
        public string CChkCode { get; set; }
        [Column("dChkDate", TypeName = "datetime")]
        public DateTime? DChkDate { get; set; }
        [Column("cChkPerson")]
        [StringLength(40)]
        public string CChkPerson { get; set; }
        [Column("VT_ID")]
        public int? VtId { get; set; }
        [Required]
        [Column("bIsSTQc")]
        public bool? BIsStqc { get; set; }
        [Column("cDefine11")]
        [StringLength(120)]
        public string CDefine11 { get; set; }
        [Column("cDefine12")]
        [StringLength(120)]
        public string CDefine12 { get; set; }
        [Column("cDefine13")]
        [StringLength(120)]
        public string CDefine13 { get; set; }
        [Column("cDefine14")]
        [StringLength(120)]
        public string CDefine14 { get; set; }
        [Column("cDefine15")]
        public int? CDefine15 { get; set; }
        [Column("cDefine16")]
        public double? CDefine16 { get; set; }
        [Column("gspcheck")]
        [StringLength(10)]
        public string Gspcheck { get; set; }
        [Column("ipurorderid")]
        public long? Ipurorderid { get; set; }
        [Column("ipurarriveid")]
        public long? Ipurarriveid { get; set; }
        [Column("iarriveid")]
        [StringLength(30)]
        public string Iarriveid { get; set; }
        [Column("isalebillid")]
        [StringLength(30)]
        public string Isalebillid { get; set; }
        [Column("ufts")]
        public byte[] Ufts { get; set; }
        [Column("iTaxRate", TypeName = "decimal(20, 6)")]
        public decimal? ITaxRate { get; set; }
        [Column("iExchRate")]
        public double? IExchRate { get; set; }
        [Column("cExch_Name")]
        [StringLength(8)]
        public string CExchName { get; set; }
        [Column("bOMFirst")]
        public bool? BOmfirst { get; set; }
        [Column("bFromPreYear")]
        public bool? BFromPreYear { get; set; }
        [Column("bIsLsQuery")]
        public bool? BIsLsQuery { get; set; }
        [Column("bIsComplement")]
        public short? BIsComplement { get; set; }
        [Column("iDiscountTaxType")]
        public byte? IDiscountTaxType { get; set; }
        [Column("ireturncount")]
        public int? Ireturncount { get; set; }
        [Column("iverifystate")]
        public int? Iverifystate { get; set; }
        [Column("iswfcontrolled")]
        public int? Iswfcontrolled { get; set; }
        [Column("cModifyPerson")]
        [StringLength(50)]
        public string CModifyPerson { get; set; }
        [Column("dModifyDate", TypeName = "datetime")]
        public DateTime? DModifyDate { get; set; }
        [Column("dnmaketime", TypeName = "datetime")]
        public DateTime? Dnmaketime { get; set; }
        [Column("dnmodifytime", TypeName = "datetime")]
        public DateTime? Dnmodifytime { get; set; }
        [Column("dnverifytime", TypeName = "datetime")]
        public DateTime? Dnverifytime { get; set; }
        [Column("bredvouch")]
        public int? Bredvouch { get; set; }
        [Column("cVenPUOMProtocol")]
        [StringLength(20)]
        public string CVenPuomprotocol { get; set; }
        [Column("dCreditStart", TypeName = "datetime")]
        public DateTime? DCreditStart { get; set; }
        [Column("iCreditPeriod")]
        public int? ICreditPeriod { get; set; }
        [Column("dGatheringDate", TypeName = "datetime")]
        public DateTime? DGatheringDate { get; set; }
        [Column("bCredit")]
        public byte? BCredit { get; set; }
        [Column("iFlowId")]
        public int? IFlowId { get; set; }
        [Column("cPZID")]
        [StringLength(30)]
        public string CPzid { get; set; }
        [Column("cSourceLs")]
        [StringLength(4)]
        public string CSourceLs { get; set; }
        [Column("cSourceCodeLs")]
        [StringLength(20)]
        public string CSourceCodeLs { get; set; }
        [Column("iPrintCount")]
        public int? IPrintCount { get; set; }
        [Column("csysbarcode")]
        [StringLength(60)]
        public string Csysbarcode { get; set; }
        [Column("cCurrentAuditor")]
        [StringLength(200)]
        public string CCurrentAuditor { get; set; }
    }
}
