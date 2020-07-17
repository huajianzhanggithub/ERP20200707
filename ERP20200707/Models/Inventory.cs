using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP20200707.Data
{
    public partial class Inventory
    {
        [Key]
        [Column("cInvCode")]
        [StringLength(60)]
        public string CInvCode { get; set; }
        [Column("cInvAddCode")]
        [StringLength(255)]
        public string CInvAddCode { get; set; }
        [Column("cInvName")]
        [StringLength(255)]
        public string CInvName { get; set; }
        [Column("cInvStd")]
        [StringLength(255)]
        public string CInvStd { get; set; }
        [Column("cInvCCode")]
        [StringLength(12)]
        public string CInvCcode { get; set; }
        [Column("cVenCode")]
        [StringLength(20)]
        public string CVenCode { get; set; }
        [Column("cReplaceItem")]
        [StringLength(60)]
        public string CReplaceItem { get; set; }
        [Column("cPosition")]
        [StringLength(20)]
        public string CPosition { get; set; }
        [Column("bSale")]
        public bool BSale { get; set; }
        [Column("bPurchase")]
        public bool BPurchase { get; set; }
        [Column("bSelf")]
        public bool BSelf { get; set; }
        [Column("bComsume")]
        public bool BComsume { get; set; }
        [Column("bProducing")]
        public bool BProducing { get; set; }
        [Column("bService")]
        public bool BService { get; set; }
        [Column("bAccessary")]
        public bool BAccessary { get; set; }
        [Column("iTaxRate")]
        public double? ITaxRate { get; set; }
        [Column("iInvWeight")]
        public double? IInvWeight { get; set; }
        [Column("iVolume")]
        public double? IVolume { get; set; }
        [Column("iInvRCost")]
        public double? IInvRcost { get; set; }
        [Column("iInvSPrice")]
        public double? IInvSprice { get; set; }
        [Column("iInvSCost")]
        public double? IInvScost { get; set; }
        [Column("iInvLSCost")]
        public double? IInvLscost { get; set; }
        [Column("iInvNCost")]
        public double? IInvNcost { get; set; }
        [Column("iInvAdvance")]
        public double? IInvAdvance { get; set; }
        [Column("iInvBatch")]
        public double? IInvBatch { get; set; }
        [Column("iSafeNum")]
        public double? ISafeNum { get; set; }
        [Column("iTopSum")]
        public double? ITopSum { get; set; }
        [Column("iLowSum")]
        public double? ILowSum { get; set; }
        [Column("iOverStock")]
        public double? IOverStock { get; set; }
        [Column("cInvABC")]
        [StringLength(1)]
        public string CInvAbc { get; set; }
        [Column("bInvQuality")]
        public bool BInvQuality { get; set; }
        [Column("bInvBatch")]
        public bool BInvBatch { get; set; }
        [Column("bInvEntrust")]
        public bool BInvEntrust { get; set; }
        [Column("bInvOverStock")]
        public bool BInvOverStock { get; set; }
        [Column("dSDate", TypeName = "datetime")]
        public DateTime? DSdate { get; set; }
        [Column("dEDate", TypeName = "datetime")]
        public DateTime? DEdate { get; set; }
        [Column("bFree1")]
        public bool BFree1 { get; set; }
        [Column("bFree2")]
        public bool BFree2 { get; set; }
        [Column("cInvDefine1")]
        [StringLength(20)]
        public string CInvDefine1 { get; set; }
        [Column("cInvDefine2")]
        [StringLength(20)]
        public string CInvDefine2 { get; set; }
        [Column("cInvDefine3")]
        [StringLength(20)]
        public string CInvDefine3 { get; set; }
        [Column("I_id")]
        public int IId { get; set; }
        [Column("bInvType")]
        public bool? BInvType { get; set; }
        [Column("iInvMPCost")]
        public double? IInvMpcost { get; set; }
        [Column("cQuality")]
        [StringLength(100)]
        public string CQuality { get; set; }
        [Column("iInvSaleCost")]
        public double? IInvSaleCost { get; set; }
        [Column("iInvSCost1")]
        public double? IInvScost1 { get; set; }
        [Column("iInvSCost2")]
        public double? IInvScost2 { get; set; }
        [Column("iInvSCost3")]
        public double? IInvScost3 { get; set; }
        [Required]
        [Column("bFree3")]
        public bool? BFree3 { get; set; }
        [Required]
        [Column("bFree4")]
        public bool? BFree4 { get; set; }
        [Required]
        [Column("bFree5")]
        public bool? BFree5 { get; set; }
        [Required]
        [Column("bFree6")]
        public bool? BFree6 { get; set; }
        [Required]
        [Column("bFree7")]
        public bool? BFree7 { get; set; }
        [Required]
        [Column("bFree8")]
        public bool? BFree8 { get; set; }
        [Required]
        [Column("bFree9")]
        public bool? BFree9 { get; set; }
        [Required]
        [Column("bFree10")]
        public bool? BFree10 { get; set; }
        [Column("cCreatePerson")]
        [StringLength(20)]
        public string CCreatePerson { get; set; }
        [Column("cModifyPerson")]
        [StringLength(20)]
        public string CModifyPerson { get; set; }
        [Column("dModifyDate", TypeName = "datetime")]
        public DateTime? DModifyDate { get; set; }
        [Column("fSubscribePoint")]
        public double? FSubscribePoint { get; set; }
        [Column("fVagQuantity")]
        public double? FVagQuantity { get; set; }
        [Column("cValueType")]
        [StringLength(20)]
        public string CValueType { get; set; }
        [Required]
        [Column("bFixExch")]
        public bool? BFixExch { get; set; }
        [Column("fOutExcess")]
        public double? FOutExcess { get; set; }
        [Column("fInExcess")]
        public double? FInExcess { get; set; }
        [Column("iMassDate")]
        public short? IMassDate { get; set; }
        [Column("iWarnDays")]
        public short? IWarnDays { get; set; }
        [Column("fExpensesExch")]
        public double? FExpensesExch { get; set; }
        [Required]
        [Column("bTrack")]
        public bool? BTrack { get; set; }
        [Required]
        [Column("bSerial")]
        public bool? BSerial { get; set; }
        [Required]
        [Column("bBarCode")]
        public bool? BBarCode { get; set; }
        [Column("iId")]
        public int? IId1 { get; set; }
        [Column("cBarCode")]
        [StringLength(30)]
        public string CBarCode { get; set; }
        [Column("cInvDefine4")]
        [StringLength(60)]
        public string CInvDefine4 { get; set; }
        [Column("cInvDefine5")]
        [StringLength(60)]
        public string CInvDefine5 { get; set; }
        [Column("cInvDefine6")]
        [StringLength(60)]
        public string CInvDefine6 { get; set; }
        [Column("cInvDefine7")]
        [StringLength(120)]
        public string CInvDefine7 { get; set; }
        [Column("cInvDefine8")]
        [StringLength(120)]
        public string CInvDefine8 { get; set; }
        [Column("cInvDefine9")]
        [StringLength(120)]
        public string CInvDefine9 { get; set; }
        [Column("cInvDefine10")]
        [StringLength(120)]
        public string CInvDefine10 { get; set; }
        [Column("cInvDefine11")]
        public int? CInvDefine11 { get; set; }
        [Column("cInvDefine12")]
        public int? CInvDefine12 { get; set; }
        [Column("cInvDefine13")]
        public double? CInvDefine13 { get; set; }
        [Column("cInvDefine14")]
        public double? CInvDefine14 { get; set; }
        [Column("cInvDefine15", TypeName = "datetime")]
        public DateTime? CInvDefine15 { get; set; }
        [Column("cInvDefine16", TypeName = "datetime")]
        public DateTime? CInvDefine16 { get; set; }
        [Column("iGroupType")]
        public byte IGroupType { get; set; }
        [Column("cGroupCode")]
        [StringLength(35)]
        public string CGroupCode { get; set; }
        [Column("cComUnitCode")]
        [StringLength(35)]
        public string CComUnitCode { get; set; }
        [Column("cAssComUnitCode")]
        [StringLength(35)]
        public string CAssComUnitCode { get; set; }
        [Column("cSAComUnitCode")]
        [StringLength(35)]
        public string CSacomUnitCode { get; set; }
        [Column("cPUComUnitCode")]
        [StringLength(35)]
        public string CPucomUnitCode { get; set; }
        [Column("cSTComUnitCode")]
        [StringLength(35)]
        public string CStcomUnitCode { get; set; }
        [Column("cCAComUnitCode")]
        [StringLength(35)]
        public string CCacomUnitCode { get; set; }
        [Column("cFrequency")]
        [StringLength(10)]
        public string CFrequency { get; set; }
        [Column("iFrequency")]
        public short? IFrequency { get; set; }
        [Column("iDays")]
        public short? IDays { get; set; }
        [Column("dLastDate", TypeName = "datetime")]
        public DateTime? DLastDate { get; set; }
        [Column("iWastage")]
        public double? IWastage { get; set; }
        [Required]
        [Column("bSolitude")]
        public bool? BSolitude { get; set; }
        [Column("cEnterprise")]
        [StringLength(100)]
        public string CEnterprise { get; set; }
        [Column("cAddress")]
        [StringLength(255)]
        public string CAddress { get; set; }
        [Column("cFile")]
        [StringLength(40)]
        public string CFile { get; set; }
        [Column("cLabel")]
        [StringLength(30)]
        public string CLabel { get; set; }
        [Column("cCheckOut")]
        [StringLength(30)]
        public string CCheckOut { get; set; }
        [Column("cLicence")]
        [StringLength(30)]
        public string CLicence { get; set; }
        [Required]
        [Column("bSpecialties")]
        public bool? BSpecialties { get; set; }
        [Column("cDefWareHouse")]
        [StringLength(10)]
        public string CDefWareHouse { get; set; }
        [Column("iHighPrice")]
        public double? IHighPrice { get; set; }
        [Column("iExpSaleRate")]
        public double? IExpSaleRate { get; set; }
        [Column("cPriceGroup")]
        [StringLength(20)]
        public string CPriceGroup { get; set; }
        [Column("cOfferGrade")]
        [StringLength(20)]
        public string COfferGrade { get; set; }
        [Column("iOfferRate")]
        public double? IOfferRate { get; set; }
        [Column("cMonth")]
        [StringLength(6)]
        public string CMonth { get; set; }
        [Column("iAdvanceDate")]
        public short? IAdvanceDate { get; set; }
        [Column("cCurrencyName")]
        [StringLength(60)]
        public string CCurrencyName { get; set; }
        [Column("cProduceAddress")]
        [StringLength(255)]
        public string CProduceAddress { get; set; }
        [Column("cProduceNation")]
        [StringLength(60)]
        public string CProduceNation { get; set; }
        [Column("cRegisterNo")]
        [StringLength(60)]
        public string CRegisterNo { get; set; }
        [Column("cEnterNo")]
        [StringLength(60)]
        public string CEnterNo { get; set; }
        [Column("cPackingType")]
        [StringLength(60)]
        public string CPackingType { get; set; }
        [Column("cEnglishName")]
        [StringLength(100)]
        public string CEnglishName { get; set; }
        [Required]
        [Column("bPropertyCheck")]
        public bool? BPropertyCheck { get; set; }
        [Column("cPreparationType")]
        [StringLength(30)]
        public string CPreparationType { get; set; }
        [Column("cCommodity")]
        [StringLength(60)]
        public string CCommodity { get; set; }
        [Column("iRecipeBatch")]
        public byte IRecipeBatch { get; set; }
        [Column("cNotPatentName")]
        [StringLength(30)]
        public string CNotPatentName { get; set; }
        [Column("pubufts")]
        public byte[] Pubufts { get; set; }
        [Required]
        [Column("bPromotSales")]
        public bool? BPromotSales { get; set; }
        [Column("iPlanPolicy")]
        public short? IPlanPolicy { get; set; }
        [Column("iROPMethod")]
        public short? IRopmethod { get; set; }
        [Column("iBatchRule")]
        public short? IBatchRule { get; set; }
        [Column("fBatchIncrement")]
        public double? FBatchIncrement { get; set; }
        [Column("iAssureProvideDays")]
        public int? IAssureProvideDays { get; set; }
        [Column("iTestStyle")]
        public short? ITestStyle { get; set; }
        [Column("iDTMethod")]
        public short? IDtmethod { get; set; }
        [Column("fDTRate")]
        public double? FDtrate { get; set; }
        [Column("fDTNum")]
        public double? FDtnum { get; set; }
        [Column("cDTUnit")]
        [StringLength(35)]
        public string CDtunit { get; set; }
        [Column("iDTStyle")]
        public short? IDtstyle { get; set; }
        [Column("iQTMethod")]
        public int? IQtmethod { get; set; }
        [Column("PictureGUID")]
        public Guid? PictureGuid { get; set; }
        [Required]
        [Column("bPlanInv")]
        public bool? BPlanInv { get; set; }
        [Required]
        [Column("bProxyForeign")]
        public bool? BProxyForeign { get; set; }
        [Required]
        [Column("bATOModel")]
        public bool? BAtomodel { get; set; }
        [Required]
        [Column("bCheckItem")]
        public bool? BCheckItem { get; set; }
        [Required]
        [Column("bPTOModel")]
        public bool? BPtomodel { get; set; }
        [Required]
        [Column("bEquipment")]
        public bool? BEquipment { get; set; }
        [Column("cProductUnit")]
        [StringLength(35)]
        public string CProductUnit { get; set; }
        [Column("fOrderUpLimit")]
        public double? FOrderUpLimit { get; set; }
        [Column("cMassUnit")]
        public short? CMassUnit { get; set; }
        [Column("fRetailPrice")]
        public double? FRetailPrice { get; set; }
        [Column("cInvDepCode")]
        [StringLength(12)]
        public string CInvDepCode { get; set; }
        [Column("iAlterAdvance")]
        public int? IAlterAdvance { get; set; }
        [Column("fAlterBaseNum")]
        public double? FAlterBaseNum { get; set; }
        [Column("cPlanMethod")]
        [StringLength(1)]
        public string CPlanMethod { get; set; }
        [Required]
        [Column("bMPS")]
        public bool? BMps { get; set; }
        [Required]
        [Column("bROP")]
        public bool? BRop { get; set; }
        [Required]
        [Column("bRePlan")]
        public bool? BRePlan { get; set; }
        [Column("cSRPolicy")]
        [StringLength(2)]
        public string CSrpolicy { get; set; }
        [Required]
        [Column("bBillUnite")]
        public bool? BBillUnite { get; set; }
        [Column("iSupplyDay")]
        public int? ISupplyDay { get; set; }
        [Column("fSupplyMulti")]
        public double? FSupplyMulti { get; set; }
        [Column("fMinSupply")]
        public double? FMinSupply { get; set; }
        [Required]
        [Column("bCutMantissa")]
        public bool? BCutMantissa { get; set; }
        [Column("cInvPersonCode")]
        [StringLength(20)]
        public string CInvPersonCode { get; set; }
        [Column("iInvTfId")]
        public int? IInvTfId { get; set; }
        [Column("cEngineerFigNo")]
        [StringLength(60)]
        public string CEngineerFigNo { get; set; }
        [Required]
        [Column("bInTotalCost")]
        public bool? BInTotalCost { get; set; }
        [Column("iSupplyType")]
        public short ISupplyType { get; set; }
        [Required]
        [Column("bConfigFree1")]
        public bool? BConfigFree1 { get; set; }
        [Required]
        [Column("bConfigFree2")]
        public bool? BConfigFree2 { get; set; }
        [Required]
        [Column("bConfigFree3")]
        public bool? BConfigFree3 { get; set; }
        [Required]
        [Column("bConfigFree4")]
        public bool? BConfigFree4 { get; set; }
        [Required]
        [Column("bConfigFree5")]
        public bool? BConfigFree5 { get; set; }
        [Required]
        [Column("bConfigFree6")]
        public bool? BConfigFree6 { get; set; }
        [Required]
        [Column("bConfigFree7")]
        public bool? BConfigFree7 { get; set; }
        [Required]
        [Column("bConfigFree8")]
        public bool? BConfigFree8 { get; set; }
        [Required]
        [Column("bConfigFree9")]
        public bool? BConfigFree9 { get; set; }
        [Required]
        [Column("bConfigFree10")]
        public bool? BConfigFree10 { get; set; }
        [Column("iDTLevel")]
        public short? IDtlevel { get; set; }
        [Column("cDTAQL")]
        [StringLength(20)]
        public string CDtaql { get; set; }
        [Required]
        [Column("bPeriodDT")]
        public bool? BPeriodDt { get; set; }
        [Column("cDTPeriod")]
        [StringLength(30)]
        public string CDtperiod { get; set; }
        [Column("iBigMonth")]
        public int? IBigMonth { get; set; }
        [Column("iBigDay")]
        public int? IBigDay { get; set; }
        [Column("iSmallMonth")]
        public int? ISmallMonth { get; set; }
        [Column("iSmallDay")]
        public int? ISmallDay { get; set; }
        [Required]
        [Column("bOutInvDT")]
        public bool? BOutInvDt { get; set; }
        [Required]
        [Column("bBackInvDT")]
        public bool? BBackInvDt { get; set; }
        [Column("iEndDTStyle")]
        public short? IEndDtstyle { get; set; }
        [Column("bDTWarnInv")]
        public bool? BDtwarnInv { get; set; }
        [Column("fBackTaxRate")]
        public double? FBackTaxRate { get; set; }
        [Column("cCIQCode")]
        [StringLength(30)]
        public string CCiqcode { get; set; }
        [Column("cWGroupCode")]
        [StringLength(35)]
        public string CWgroupCode { get; set; }
        [Column("cWUnit")]
        [StringLength(35)]
        public string CWunit { get; set; }
        [Column("fGrossW")]
        public double? FGrossW { get; set; }
        [Column("cVGroupCode")]
        [StringLength(35)]
        public string CVgroupCode { get; set; }
        [Column("cVUnit")]
        [StringLength(35)]
        public string CVunit { get; set; }
        [Column("fLength")]
        public double? FLength { get; set; }
        [Column("fWidth")]
        public double? FWidth { get; set; }
        [Column("fHeight")]
        public double? FHeight { get; set; }
        [Column("iDTUCounter")]
        public int? IDtucounter { get; set; }
        [Column("iDTDCounter")]
        public int? IDtdcounter { get; set; }
        [Column("iBatchCounter")]
        public int? IBatchCounter { get; set; }
        [Column("cShopUnit")]
        [StringLength(35)]
        public string CShopUnit { get; set; }
        [Column("cPurPersonCode")]
        [StringLength(20)]
        public string CPurPersonCode { get; set; }
        [Required]
        [Column("bImportMedicine")]
        public bool? BImportMedicine { get; set; }
        [Required]
        [Column("bFirstBusiMedicine")]
        public bool? BFirstBusiMedicine { get; set; }
        [Required]
        [Column("bForeExpland")]
        public bool? BForeExpland { get; set; }
        [Column("cInvPlanCode")]
        [StringLength(20)]
        public string CInvPlanCode { get; set; }
        [Column("fConvertRate")]
        public double FConvertRate { get; set; }
        [Column("dReplaceDate", TypeName = "datetime")]
        public DateTime? DReplaceDate { get; set; }
        [Required]
        [Column("bInvModel")]
        public bool? BInvModel { get; set; }
        [Required]
        [Column("bKCCutMantissa")]
        public bool? BKccutMantissa { get; set; }
        [Required]
        [Column("bReceiptByDT")]
        public bool? BReceiptByDt { get; set; }
        [Column("iImpTaxRate")]
        public double? IImpTaxRate { get; set; }
        [Column("iExpTaxRate")]
        public double? IExpTaxRate { get; set; }
        [Required]
        [Column("bExpSale")]
        public bool? BExpSale { get; set; }
        [Column("iDrawBatch")]
        public double? IDrawBatch { get; set; }
        [Required]
        [Column("bCheckBSATP")]
        public bool? BCheckBsatp { get; set; }
        [Column("cInvProjectCode")]
        [StringLength(16)]
        public string CInvProjectCode { get; set; }
        [Column("iTestRule")]
        public short? ITestRule { get; set; }
        [Column("cRuleCode")]
        [StringLength(20)]
        public string CRuleCode { get; set; }
        [Required]
        [Column("bCheckFree1")]
        public bool? BCheckFree1 { get; set; }
        [Required]
        [Column("bCheckFree2")]
        public bool? BCheckFree2 { get; set; }
        [Required]
        [Column("bCheckFree3")]
        public bool? BCheckFree3 { get; set; }
        [Required]
        [Column("bCheckFree4")]
        public bool? BCheckFree4 { get; set; }
        [Required]
        [Column("bCheckFree5")]
        public bool? BCheckFree5 { get; set; }
        [Required]
        [Column("bCheckFree6")]
        public bool? BCheckFree6 { get; set; }
        [Required]
        [Column("bCheckFree7")]
        public bool? BCheckFree7 { get; set; }
        [Required]
        [Column("bCheckFree8")]
        public bool? BCheckFree8 { get; set; }
        [Required]
        [Column("bCheckFree9")]
        public bool? BCheckFree9 { get; set; }
        [Required]
        [Column("bCheckFree10")]
        public bool? BCheckFree10 { get; set; }
        [Required]
        [Column("bBomMain")]
        public bool? BBomMain { get; set; }
        [Required]
        [Column("bBomSub")]
        public bool? BBomSub { get; set; }
        [Required]
        [Column("bProductBill")]
        public bool? BProductBill { get; set; }
        [Column("iCheckATP")]
        public short ICheckAtp { get; set; }
        [Column("iInvATPId")]
        public int? IInvAtpid { get; set; }
        [Column("iPlanTfDay")]
        public int? IPlanTfDay { get; set; }
        [Column("iOverlapDay")]
        public int? IOverlapDay { get; set; }
        [Required]
        [Column("bPiece")]
        public bool? BPiece { get; set; }
        [Required]
        [Column("bSrvItem")]
        public bool? BSrvItem { get; set; }
        [Required]
        [Column("bSrvFittings")]
        public bool? BSrvFittings { get; set; }
        [Column("fMaxSupply")]
        public double? FMaxSupply { get; set; }
        [Column("fMinSplit")]
        public double? FMinSplit { get; set; }
        [Required]
        [Column("bSpecialOrder")]
        public bool? BSpecialOrder { get; set; }
        [Required]
        [Column("bTrackSaleBill")]
        public bool? BTrackSaleBill { get; set; }
        [Column("cInvMnemCode")]
        [StringLength(40)]
        public string CInvMnemCode { get; set; }
        [Column("iPlanDefault")]
        public short? IPlanDefault { get; set; }
        [Column("iPFBatchQty")]
        public double? IPfbatchQty { get; set; }
        [Column("iAllocatePrintDgt")]
        public int? IAllocatePrintDgt { get; set; }
        [Required]
        [Column("bCheckBatch")]
        public bool? BCheckBatch { get; set; }
        [Required]
        [Column("bMngOldpart")]
        public bool? BMngOldpart { get; set; }
        [Column("iOldpartMngRule")]
        public short? IOldpartMngRule { get; set; }

        [ForeignKey(nameof(CInvCcode))]
        [InverseProperty(nameof(InventoryClass.Inventory))]
        public virtual InventoryClass CInvCcodeNavigation { get; set; }
    }
}
