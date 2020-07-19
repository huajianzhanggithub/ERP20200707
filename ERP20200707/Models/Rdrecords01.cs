using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP20200707.Models
{
    [Table("rdrecords01")]
    public partial class Rdrecords01
    {
        [Key]
        [Column("AutoID")]
        public long AutoId { get; set; }
        [Column("ID")]
        public long Id { get; set; }
        [Required]
        [Column("cInvCode")]
        [StringLength(60)]
        public string CInvCode { get; set; }
        [Column("iNum", TypeName = "decimal(30, 10)")]
        public decimal? INum { get; set; }
        [Column("iQuantity", TypeName = "decimal(30, 10)")]
        public decimal? IQuantity { get; set; }
        [Column("iUnitCost", TypeName = "decimal(30, 10)")]
        public decimal? IUnitCost { get; set; }
        [Column("iPrice", TypeName = "money")]
        public decimal? IPrice { get; set; }
        [Column("iAPrice", TypeName = "money")]
        public decimal? IAprice { get; set; }
        [Column("iPUnitCost", TypeName = "decimal(30, 10)")]
        public decimal? IPunitCost { get; set; }
        [Column("iPPrice", TypeName = "money")]
        public decimal? IPprice { get; set; }
        [Column("cBatch")]
        [StringLength(60)]
        public string CBatch { get; set; }
        [Column("cVouchCode")]
        public long? CVouchCode { get; set; }
        [Column("cInVouchCode")]
        [StringLength(30)]
        public string CInVouchCode { get; set; }
        [Column("cinvouchtype")]
        [StringLength(2)]
        public string Cinvouchtype { get; set; }
        [Column("iSOutQuantity", TypeName = "decimal(30, 10)")]
        public decimal? ISoutQuantity { get; set; }
        [Column("iSOutNum", TypeName = "decimal(30, 10)")]
        public decimal? ISoutNum { get; set; }
        [Column("cFree1")]
        [StringLength(20)]
        public string CFree1 { get; set; }
        [Column("cFree2")]
        [StringLength(20)]
        public string CFree2 { get; set; }
        [Column("iFlag")]
        public byte IFlag { get; set; }
        [Column("dSDate", TypeName = "datetime")]
        public DateTime? DSdate { get; set; }
        [Column("iTax", TypeName = "money")]
        public decimal? ITax { get; set; }
        [Column("iSQuantity", TypeName = "decimal(30, 10)")]
        public decimal? ISquantity { get; set; }
        [Column("iSNum", TypeName = "decimal(30, 10)")]
        public decimal? ISnum { get; set; }
        [Column("iMoney", TypeName = "money")]
        public decimal? IMoney { get; set; }
        [Column("iFNum", TypeName = "decimal(30, 10)")]
        public decimal? IFnum { get; set; }
        [Column("iFQuantity", TypeName = "decimal(30, 10)")]
        public decimal? IFquantity { get; set; }
        [Column("dVDate", TypeName = "datetime")]
        public DateTime? DVdate { get; set; }
        [Column("cPosition")]
        [StringLength(20)]
        public string CPosition { get; set; }
        [Column("cDefine22")]
        [StringLength(60)]
        public string CDefine22 { get; set; }
        [Column("cDefine23")]
        [StringLength(60)]
        public string CDefine23 { get; set; }
        [Column("cDefine24")]
        [StringLength(60)]
        public string CDefine24 { get; set; }
        [Column("cDefine25")]
        [StringLength(60)]
        public string CDefine25 { get; set; }
        [Column("cDefine26")]
        public double? CDefine26 { get; set; }
        [Column("cDefine27")]
        public double? CDefine27 { get; set; }
        [Column("cItem_class")]
        [StringLength(10)]
        public string CItemClass { get; set; }
        [Column("cItemCode")]
        [StringLength(60)]
        public string CItemCode { get; set; }
        [Column("iPOsID")]
        public long? IPosId { get; set; }
        [Column("fACost", TypeName = "decimal(30, 10)")]
        public decimal? FAcost { get; set; }
        [Column("cName")]
        [StringLength(255)]
        public string CName { get; set; }
        [Column("cItemCName")]
        [StringLength(20)]
        public string CItemCname { get; set; }
        [Column("cFree3")]
        [StringLength(20)]
        public string CFree3 { get; set; }
        [Column("cFree4")]
        [StringLength(20)]
        public string CFree4 { get; set; }
        [Column("cFree5")]
        [StringLength(20)]
        public string CFree5 { get; set; }
        [Column("cFree6")]
        [StringLength(20)]
        public string CFree6 { get; set; }
        [Column("cFree7")]
        [StringLength(20)]
        public string CFree7 { get; set; }
        [Column("cFree8")]
        [StringLength(20)]
        public string CFree8 { get; set; }
        [Column("cFree9")]
        [StringLength(20)]
        public string CFree9 { get; set; }
        [Column("cFree10")]
        [StringLength(20)]
        public string CFree10 { get; set; }
        [Column("cBarCode")]
        [StringLength(200)]
        public string CBarCode { get; set; }
        [Column("iNQuantity", TypeName = "decimal(30, 10)")]
        public decimal? INquantity { get; set; }
        [Column("iNNum", TypeName = "decimal(30, 10)")]
        public decimal? INnum { get; set; }
        [Column("cAssUnit")]
        [StringLength(35)]
        public string CAssUnit { get; set; }
        [Column("dMadeDate", TypeName = "datetime")]
        public DateTime? DMadeDate { get; set; }
        [Column("iMassDate")]
        public int? IMassDate { get; set; }
        [Column("cDefine28")]
        [StringLength(120)]
        public string CDefine28 { get; set; }
        [Column("cDefine29")]
        [StringLength(120)]
        public string CDefine29 { get; set; }
        [Column("cDefine30")]
        [StringLength(120)]
        public string CDefine30 { get; set; }
        [Column("cDefine31")]
        [StringLength(120)]
        public string CDefine31 { get; set; }
        [Column("cDefine32")]
        [StringLength(120)]
        public string CDefine32 { get; set; }
        [Column("cDefine33")]
        [StringLength(120)]
        public string CDefine33 { get; set; }
        [Column("cDefine34")]
        public int? CDefine34 { get; set; }
        [Column("cDefine35")]
        public int? CDefine35 { get; set; }
        [Column("cDefine36", TypeName = "datetime")]
        public DateTime? CDefine36 { get; set; }
        [Column("cDefine37", TypeName = "datetime")]
        public DateTime? CDefine37 { get; set; }
        [Column("iCheckIds")]
        public long? ICheckIds { get; set; }
        [Column("cBVencode")]
        [StringLength(20)]
        public string CBvencode { get; set; }
        [Column("chVencode")]
        [StringLength(20)]
        public string ChVencode { get; set; }
        [Column("bGsp")]
        public bool? BGsp { get; set; }
        [Column("cGspState")]
        [StringLength(20)]
        public string CGspState { get; set; }
        [Column("iArrsId")]
        public long? IArrsId { get; set; }
        [Column("cCheckCode")]
        [StringLength(30)]
        public string CCheckCode { get; set; }
        [Column("iCheckIdBaks")]
        public long? ICheckIdBaks { get; set; }
        [Column("cRejectCode")]
        [StringLength(30)]
        public string CRejectCode { get; set; }
        [Column("iRejectIds")]
        public long? IRejectIds { get; set; }
        [Column("cCheckPersonCode")]
        [StringLength(20)]
        public string CCheckPersonCode { get; set; }
        [Column("dCheckDate", TypeName = "datetime")]
        public DateTime? DCheckDate { get; set; }
        [Column("iOriTaxCost", TypeName = "decimal(20, 6)")]
        public decimal? IOriTaxCost { get; set; }
        [Column("iOriCost", TypeName = "decimal(20, 6)")]
        public decimal? IOriCost { get; set; }
        [Column("iOriMoney", TypeName = "money")]
        public decimal? IOriMoney { get; set; }
        [Column("iOriTaxPrice", TypeName = "money")]
        public decimal? IOriTaxPrice { get; set; }
        [Column("ioriSum", TypeName = "money")]
        public decimal? IoriSum { get; set; }
        [Column("iTaxRate", TypeName = "decimal(20, 6)")]
        public decimal? ITaxRate { get; set; }
        [Column("iTaxPrice", TypeName = "money")]
        public decimal? ITaxPrice { get; set; }
        [Column("iSum", TypeName = "money")]
        public decimal? ISum { get; set; }
        [Column("bTaxCost")]
        public bool? BTaxCost { get; set; }
        [Column("cPOID")]
        [StringLength(30)]
        public string CPoid { get; set; }
        [Column("cMassUnit")]
        public short? CMassUnit { get; set; }
        [Column("iMaterialFee", TypeName = "money")]
        public decimal? IMaterialFee { get; set; }
        [Column("iProcessCost", TypeName = "decimal(30, 10)")]
        public decimal? IProcessCost { get; set; }
        [Column("iProcessFee", TypeName = "money")]
        public decimal? IProcessFee { get; set; }
        [Column("dMSDate", TypeName = "datetime")]
        public DateTime? DMsdate { get; set; }
        [Column("iSMaterialFee", TypeName = "money")]
        public decimal? ISmaterialFee { get; set; }
        [Column("iSProcessFee", TypeName = "money")]
        public decimal? ISprocessFee { get; set; }
        [Column("iOMoDID")]
        public int? IOmoDid { get; set; }
        [Column("strContractId")]
        [StringLength(64)]
        public string StrContractId { get; set; }
        [Column("strCode")]
        [StringLength(150)]
        public string StrCode { get; set; }
        [Column("bChecked")]
        public bool? BChecked { get; set; }
        [Column("bRelated")]
        public bool? BRelated { get; set; }
        [Column("iOMoMID")]
        public long? IOmoMid { get; set; }
        [Column("iMatSettleState")]
        public int IMatSettleState { get; set; }
        [Column("iBillSettleCount")]
        public int IBillSettleCount { get; set; }
        [Column("bLPUseFree")]
        public bool? BLpuseFree { get; set; }
        [Column("iOriTrackID")]
        public long? IOriTrackId { get; set; }
        [Column("coritracktype")]
        [StringLength(2)]
        public string Coritracktype { get; set; }
        [Column("cbaccounter")]
        [StringLength(30)]
        public string Cbaccounter { get; set; }
        [Column("dbKeepDate", TypeName = "datetime")]
        public DateTime? DbKeepDate { get; set; }
        [Column("bCosting")]
        public bool? BCosting { get; set; }
        [Column("iSumBillQuantity", TypeName = "decimal(30, 10)")]
        public decimal? ISumBillQuantity { get; set; }
        [Column("bVMIUsed")]
        public bool? BVmiused { get; set; }
        [Column("iVMISettleQuantity", TypeName = "decimal(30, 10)")]
        public decimal? IVmisettleQuantity { get; set; }
        [Column("iVMISettleNum", TypeName = "decimal(30, 10)")]
        public decimal? IVmisettleNum { get; set; }
        [Column("cvmivencode")]
        [StringLength(20)]
        public string Cvmivencode { get; set; }
        [Column("iInvSNCount")]
        public int? IInvSncount { get; set; }
        [Column("cwhpersoncode")]
        [StringLength(20)]
        public string Cwhpersoncode { get; set; }
        [Column("cwhpersonname")]
        [StringLength(50)]
        public string Cwhpersonname { get; set; }
        [Column("impcost", TypeName = "decimal(30, 10)")]
        public decimal? Impcost { get; set; }
        [Column("iIMOSID")]
        public int? IImosid { get; set; }
        [Column("iIMBSID")]
        public int? IImbsid { get; set; }
        [Column("cbarvcode")]
        [StringLength(30)]
        public string Cbarvcode { get; set; }
        [Column("dbarvdate")]
        [StringLength(30)]
        public string Dbarvdate { get; set; }
        [Column("iinvexchrate", TypeName = "decimal(30, 10)")]
        public decimal? Iinvexchrate { get; set; }
        [Column("corufts")]
        [StringLength(12)]
        public string Corufts { get; set; }
        [Column("comcode")]
        [StringLength(30)]
        public string Comcode { get; set; }
        [Column("strContractGUID")]
        public Guid? StrContractGuid { get; set; }
        [Column("iExpiratDateCalcu")]
        public short? IExpiratDateCalcu { get; set; }
        [Column("cExpirationdate")]
        [StringLength(10)]
        public string CExpirationdate { get; set; }
        [Column("dExpirationdate", TypeName = "datetime")]
        public DateTime? DExpirationdate { get; set; }
        [Column("cciqbookcode")]
        [StringLength(20)]
        public string Cciqbookcode { get; set; }
        [Column("iBondedSumQty", TypeName = "decimal(34, 8)")]
        public decimal? IBondedSumQty { get; set; }
        [Column("iordertype")]
        public byte? Iordertype { get; set; }
        [Column("iorderdid")]
        public int? Iorderdid { get; set; }
        [Column("iordercode")]
        [StringLength(30)]
        public string Iordercode { get; set; }
        [Column("iorderseq")]
        public int? Iorderseq { get; set; }
        [Column("isodid")]
        [StringLength(40)]
        public string Isodid { get; set; }
        [Column("isotype")]
        public byte? Isotype { get; set; }
        [Column("csocode")]
        [StringLength(40)]
        public string Csocode { get; set; }
        [Column("isoseq")]
        public int? Isoseq { get; set; }
        [Column("cBatchProperty1", TypeName = "decimal(38, 8)")]
        public decimal? CBatchProperty1 { get; set; }
        [Column("cBatchProperty2", TypeName = "decimal(38, 8)")]
        public decimal? CBatchProperty2 { get; set; }
        [Column("cBatchProperty3", TypeName = "decimal(38, 8)")]
        public decimal? CBatchProperty3 { get; set; }
        [Column("cBatchProperty4", TypeName = "decimal(38, 8)")]
        public decimal? CBatchProperty4 { get; set; }
        [Column("cBatchProperty5", TypeName = "decimal(38, 8)")]
        public decimal? CBatchProperty5 { get; set; }
        [Column("cBatchProperty6")]
        [StringLength(120)]
        public string CBatchProperty6 { get; set; }
        [Column("cBatchProperty7")]
        [StringLength(120)]
        public string CBatchProperty7 { get; set; }
        [Column("cBatchProperty8")]
        [StringLength(120)]
        public string CBatchProperty8 { get; set; }
        [Column("cBatchProperty9")]
        [StringLength(120)]
        public string CBatchProperty9 { get; set; }
        [Column("cBatchProperty10", TypeName = "datetime")]
        public DateTime? CBatchProperty10 { get; set; }
        [Column("cbMemo")]
        [StringLength(255)]
        public string CbMemo { get; set; }
        [Column("iFaQty", TypeName = "decimal(38, 6)")]
        public decimal? IFaQty { get; set; }
        [Column("isTax", TypeName = "decimal(38, 6)")]
        public decimal? IsTax { get; set; }
        [Column("irowno")]
        public int? Irowno { get; set; }
        [Column("strowguid")]
        public Guid? Strowguid { get; set; }
        [Column("rowufts")]
        public byte[] Rowufts { get; set; }
        [Column("ipreuseqty", TypeName = "decimal(38, 8)")]
        public decimal? Ipreuseqty { get; set; }
        [Column("ipreuseinum", TypeName = "decimal(38, 8)")]
        public decimal? Ipreuseinum { get; set; }
        [Column("iDebitIDs")]
        public int? IDebitIds { get; set; }
        [Column(TypeName = "decimal(30, 10)")]
        public decimal? OutCopiedQuantity { get; set; }
        [Column("iOldPartId")]
        public int? IOldPartId { get; set; }
        [Column("fOldQuantity", TypeName = "decimal(30, 10)")]
        public decimal? FOldQuantity { get; set; }
        [Column("cbsysbarcode")]
        [StringLength(80)]
        public string Cbsysbarcode { get; set; }
        [Column("bmergecheck")]
        public bool? Bmergecheck { get; set; }
        [Column("iMergeCheckAutoId")]
        public int? IMergeCheckAutoId { get; set; }
        [Column("bnoitemused")]
        public byte? Bnoitemused { get; set; }
        [Column("cReworkMOCode")]
        [StringLength(30)]
        public string CReworkMocode { get; set; }
        [Column("iReworkMODetailsid")]
        public int? IReworkModetailsid { get; set; }
        [Column("iProductType")]
        public int? IProductType { get; set; }
        [Column("cMainInvCode")]
        [StringLength(30)]
        public string CMainInvCode { get; set; }
        [Column("iMainMoDetailsID")]
        public int? IMainMoDetailsId { get; set; }
        [Column("iShareMaterialFee", TypeName = "decimal(38, 6)")]
        public decimal? IShareMaterialFee { get; set; }
        [Column("cplanlotcode")]
        [StringLength(80)]
        public string Cplanlotcode { get; set; }
        [Column("bgift")]
        public short? Bgift { get; set; }
        [Column("iposflag")]
        public short? Iposflag { get; set; }
    }
}
