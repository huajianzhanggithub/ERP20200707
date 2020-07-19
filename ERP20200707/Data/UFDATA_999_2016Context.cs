using System;
using ERP20200707.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ERP20200707.Data
{
    public partial class UFDATA_999_2016Context : DbContext
    {
        public UFDATA_999_2016Context()
        {
        }

        public UFDATA_999_2016Context(DbContextOptions<UFDATA_999_2016Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<InventoryClass> InventoryClass { get; set; }
        public virtual DbSet<RdRecord01> RdRecord01 { get; set; }
        public virtual DbSet<Rdrecords01> Rdrecords01 { get; set; }
        public virtual DbSet<TjgCgdj> TjgCgdj { get; set; }
        public virtual DbSet<TjgCgjg> TjgCgjg { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.CDepCode)
                    .HasName("aaaaaDepartment_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.CDepCode)
                    .HasName("Department_cDepCode_Idx");

                entity.Property(e => e.BIm).HasDefaultValueSql("(1)");

                entity.Property(e => e.BInheritDutyBasic).HasDefaultValueSql("(1)");

                entity.Property(e => e.BInheritWorkCalendar).HasDefaultValueSql("(1)");

                entity.Property(e => e.BRetail).HasDefaultValueSql("(0)");

                entity.Property(e => e.BShop).HasDefaultValueSql("(0)");

                entity.Property(e => e.CDepGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CDutyCode).HasDefaultValueSql("('')");

                entity.Property(e => e.CRestCode).HasDefaultValueSql("('')");

                entity.Property(e => e.DDepBeginDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pubufts)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasKey(e => e.CInvCode)
                    .HasName("aaaaaInventory_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.BAtomodel)
                    .HasName("ix_inventory_bAtoModel");

                entity.HasIndex(e => e.BMps)
                    .HasName("idx_inventory_bmps");

                entity.HasIndex(e => e.CBarCode)
                    .HasName("Index_Inventory_cbarcode");

                entity.HasIndex(e => e.CInvAddCode)
                    .HasName("cInvAddCode");

                entity.HasIndex(e => e.CInvCcode)
                    .HasName("InventoryClassInventory");

                entity.HasIndex(e => e.CInvCode)
                    .HasName("PK_Inventory_cInvCode_Clustered_Index")
                    .IsClustered();

                entity.HasIndex(e => e.CInvName)
                    .HasName("cInvName");

                entity.HasIndex(e => e.CVenCode)
                    .HasName("Inventory_CVenCode_Idx");

                entity.HasIndex(e => e.IId1)
                    .HasName("Index871_Inventory_iId");

                entity.HasIndex(e => e.Pubufts)
                    .HasName("idx_inventory_pubufts");

                entity.HasIndex(e => new { e.CInvCode, e.IId1 })
                    .HasName("Index_Inventory_cInvcode_iid");

                entity.HasIndex(e => new { e.CInvMnemCode, e.CInvCode })
                    .HasName("IX_Inventory_cInvCode_cInvMnemCode");

                entity.HasIndex(e => new { e.CSrpolicy, e.CInvCode })
                    .HasName("Index_inventory_csrpolicy_cinvcode");

                entity.HasIndex(e => new { e.CInvCode, e.CInvName, e.BPiece })
                    .HasName("IX_Inventory_PR");

                entity.Property(e => e.BAtomodel).HasDefaultValueSql("(0)");

                entity.Property(e => e.BBackInvDt).HasDefaultValueSql("(0)");

                entity.Property(e => e.BBarCode).HasDefaultValueSql("(0)");

                entity.Property(e => e.BBillUnite).HasDefaultValueSql("(0)");

                entity.Property(e => e.BBomMain).HasDefaultValueSql("(0)");

                entity.Property(e => e.BBomSub).HasDefaultValueSql("(0)");

                entity.Property(e => e.BCheckBatch).HasDefaultValueSql("(0)");

                entity.Property(e => e.BCheckBsatp).HasDefaultValueSql("(0)");

                entity.Property(e => e.BCheckFree1).HasDefaultValueSql("(0)");

                entity.Property(e => e.BCheckFree10).HasDefaultValueSql("(0)");

                entity.Property(e => e.BCheckFree2).HasDefaultValueSql("(0)");

                entity.Property(e => e.BCheckFree3).HasDefaultValueSql("(0)");

                entity.Property(e => e.BCheckFree4).HasDefaultValueSql("(0)");

                entity.Property(e => e.BCheckFree5).HasDefaultValueSql("(0)");

                entity.Property(e => e.BCheckFree6).HasDefaultValueSql("(0)");

                entity.Property(e => e.BCheckFree7).HasDefaultValueSql("(0)");

                entity.Property(e => e.BCheckFree8).HasDefaultValueSql("(0)");

                entity.Property(e => e.BCheckFree9).HasDefaultValueSql("(0)");

                entity.Property(e => e.BCheckItem).HasDefaultValueSql("(0)");

                entity.Property(e => e.BConfigFree1).HasDefaultValueSql("(0)");

                entity.Property(e => e.BConfigFree10).HasDefaultValueSql("(0)");

                entity.Property(e => e.BConfigFree2).HasDefaultValueSql("(0)");

                entity.Property(e => e.BConfigFree3).HasDefaultValueSql("(0)");

                entity.Property(e => e.BConfigFree4).HasDefaultValueSql("(0)");

                entity.Property(e => e.BConfigFree5).HasDefaultValueSql("(0)");

                entity.Property(e => e.BConfigFree6).HasDefaultValueSql("(0)");

                entity.Property(e => e.BConfigFree7).HasDefaultValueSql("(0)");

                entity.Property(e => e.BConfigFree8).HasDefaultValueSql("(0)");

                entity.Property(e => e.BConfigFree9).HasDefaultValueSql("(0)");

                entity.Property(e => e.BCutMantissa).HasDefaultValueSql("(0)");

                entity.Property(e => e.BEquipment).HasDefaultValueSql("(0)");

                entity.Property(e => e.BExpSale).HasDefaultValueSql("(0)");

                entity.Property(e => e.BFirstBusiMedicine).HasDefaultValueSql("(0)");

                entity.Property(e => e.BFixExch).HasDefaultValueSql("(0)");

                entity.Property(e => e.BForeExpland).HasDefaultValueSql("(0)");

                entity.Property(e => e.BFree10).HasDefaultValueSql("(0)");

                entity.Property(e => e.BFree3).HasDefaultValueSql("(0)");

                entity.Property(e => e.BFree4).HasDefaultValueSql("(0)");

                entity.Property(e => e.BFree5).HasDefaultValueSql("(0)");

                entity.Property(e => e.BFree6).HasDefaultValueSql("(0)");

                entity.Property(e => e.BFree7).HasDefaultValueSql("(0)");

                entity.Property(e => e.BFree8).HasDefaultValueSql("(0)");

                entity.Property(e => e.BFree9).HasDefaultValueSql("(0)");

                entity.Property(e => e.BImportMedicine).HasDefaultValueSql("(0)");

                entity.Property(e => e.BInTotalCost).HasDefaultValueSql("(0)");

                entity.Property(e => e.BInvModel).HasDefaultValueSql("(0)");

                entity.Property(e => e.BKccutMantissa).HasDefaultValueSql("(0)");

                entity.Property(e => e.BMngOldpart).HasDefaultValueSql("(0)");

                entity.Property(e => e.BMps).HasDefaultValueSql("(0)");

                entity.Property(e => e.BOutInvDt).HasDefaultValueSql("(0)");

                entity.Property(e => e.BPeriodDt).HasDefaultValueSql("(0)");

                entity.Property(e => e.BPiece).HasDefaultValueSql("(0)");

                entity.Property(e => e.BPlanInv).HasDefaultValueSql("(0)");

                entity.Property(e => e.BProductBill).HasDefaultValueSql("(0)");

                entity.Property(e => e.BPromotSales).HasDefaultValueSql("(0)");

                entity.Property(e => e.BPropertyCheck).HasDefaultValueSql("(0)");

                entity.Property(e => e.BProxyForeign).HasDefaultValueSql("(0)");

                entity.Property(e => e.BPtomodel).HasDefaultValueSql("(0)");

                entity.Property(e => e.BRePlan).HasDefaultValueSql("(0)");

                entity.Property(e => e.BReceiptByDt).HasDefaultValueSql("(0)");

                entity.Property(e => e.BRop).HasDefaultValueSql("(0)");

                entity.Property(e => e.BSerial).HasDefaultValueSql("(0)");

                entity.Property(e => e.BSolitude).HasDefaultValueSql("(0)");

                entity.Property(e => e.BSpecialOrder).HasDefaultValueSql("(0)");

                entity.Property(e => e.BSpecialties).HasDefaultValueSql("(0)");

                entity.Property(e => e.BSrvFittings).HasDefaultValueSql("(0)");

                entity.Property(e => e.BSrvItem).HasDefaultValueSql("(0)");

                entity.Property(e => e.BTrack).HasDefaultValueSql("(0)");

                entity.Property(e => e.BTrackSaleBill).HasDefaultValueSql("(0)");

                entity.Property(e => e.CMassUnit).HasDefaultValueSql("(0)");

                entity.Property(e => e.CPlanMethod).HasDefaultValueSql("('R')");

                entity.Property(e => e.CSrpolicy).HasDefaultValueSql("('PE')");

                entity.Property(e => e.FConvertRate).HasDefaultValueSql("(1)");

                entity.Property(e => e.ICheckAtp).HasDefaultValueSql("(0)");

                entity.Property(e => e.IGroupType).HasDefaultValueSql("(0)");

                entity.Property(e => e.IId).ValueGeneratedOnAdd();

                entity.Property(e => e.IRecipeBatch).HasDefaultValueSql("(0)");

                entity.Property(e => e.ISupplyType).HasDefaultValueSql("(0)");

                entity.Property(e => e.Pubufts)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.CInvCcodeNavigation)
                    .WithMany(p => p.Inventory)
                    .HasForeignKey(d => d.CInvCcode)
                    .HasConstraintName("FK__Inventory__cInvC__6399A2AA");
            });

            modelBuilder.Entity<InventoryClass>(entity =>
            {
                entity.HasKey(e => e.CInvCcode)
                    .HasName("aaaaaInventoryClass_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.CInvCname)
                    .HasName("cInvCName");

                entity.HasIndex(e => new { e.CInvCcode, e.CInvCname })
                    .HasName("IX_InventoryClass_cInvcCode_cInvcName");

                entity.Property(e => e.Pubufts)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<RdRecord01>(entity =>
            {
                entity.HasIndex(e => e.CBusCode)
                    .HasName("ix_rdecord01_cbuscode");

                entity.HasIndex(e => e.CCode)
                    .HasName("ix_rdecord01_ccode");

                entity.HasIndex(e => e.CRdCode)
                    .HasName("ix_rdecord01_crdcode");

                entity.HasIndex(e => e.CVenCode)
                    .HasName("ix_RdRecord01_cvencode");

                entity.HasIndex(e => e.CWhCode)
                    .HasName("ix_rdecord01_cwhcode");

                entity.HasIndex(e => new { e.DDate, e.BIsStqc, e.Bpufirst, e.Biafirst, e.BOmfirst, e.CBusType, e.CVouchType, e.Id })
                    .HasName("ix_rdecord01_date");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BFromPreYear).HasDefaultValueSql("(0)");

                entity.Property(e => e.BIsComplement).HasDefaultValueSql("(0)");

                entity.Property(e => e.BIsStqc).HasDefaultValueSql("(0)");

                entity.Property(e => e.BTransFlag).HasDefaultValueSql("(0)");

                entity.Property(e => e.Biafirst).HasDefaultValueSql("(0)");

                entity.Property(e => e.Bpufirst).HasDefaultValueSql("(0)");

                entity.Property(e => e.Bredvouch).HasDefaultValueSql("(0)");

                entity.Property(e => e.CModifyPerson).HasDefaultValueSql("(N'')");

                entity.Property(e => e.IDiscountTaxType).HasDefaultValueSql("(0)");

                entity.Property(e => e.IPrintCount).HasDefaultValueSql("(0)");

                entity.Property(e => e.Ireturncount).HasDefaultValueSql("(0)");

                entity.Property(e => e.Iswfcontrolled).HasDefaultValueSql("(0)");

                entity.Property(e => e.Iverifystate).HasDefaultValueSql("(0)");

                entity.Property(e => e.Ufts)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Rdrecords01>(entity =>
            {
                entity.HasKey(e => e.AutoId)
                    .HasName("aaaaaRdRecords01_PK");

                entity.HasIndex(e => e.CBarCode)
                    .HasName("ix_RdRecords01_cbarcode");

                entity.HasIndex(e => e.CBvencode)
                    .HasName("ix_RdRecords01_cbvencode");

                entity.HasIndex(e => e.Cbaccounter)
                    .HasName("IX_Rdrecords01_cBaccounter_IA");

                entity.HasIndex(e => e.IArrsId)
                    .HasName("ix_rdecords01_iArrsId");

                entity.HasIndex(e => e.IImbsid)
                    .HasName("ix_rdecords01_iIMBSID");

                entity.HasIndex(e => e.IImosid)
                    .HasName("ix_rdecords01_iIMOSID");

                entity.HasIndex(e => e.IOmoDid)
                    .HasName("ix_rdecords01_iOMoDID");

                entity.HasIndex(e => e.IPosId)
                    .HasName("ix_rdecords01_iposid");

                entity.HasIndex(e => new { e.CInvCode, e.AutoId })
                    .HasName("ix_rdecords01_cinvcode");

                entity.HasIndex(e => new { e.StrContractId, e.StrCode })
                    .HasName("ix_rdecords01_strContractId_strCode");

                entity.HasIndex(e => new { e.CVouchCode, e.Cinvouchtype, e.AutoId })
                    .HasName("ix_rdecords01_trackid");

                entity.HasIndex(e => new { e.Id, e.AutoId, e.CInvCode })
                    .HasName("ix_rdecords01_id");

                entity.Property(e => e.AutoId).ValueGeneratedNever();

                entity.Property(e => e.BLpuseFree).HasDefaultValueSql("(0)");

                entity.Property(e => e.BVmiused).HasDefaultValueSql("(0)");

                entity.Property(e => e.Bgift).HasDefaultValueSql("(0)");

                entity.Property(e => e.CExpirationdate).IsUnicode(false);

                entity.Property(e => e.Cbaccounter).HasDefaultValueSql("(N'')");

                entity.Property(e => e.Corufts)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IBillSettleCount).HasDefaultValueSql("(0)");

                entity.Property(e => e.IFlag).HasDefaultValueSql("(0)");

                entity.Property(e => e.IMatSettleState).HasDefaultValueSql("(0)");

                entity.Property(e => e.IOriTrackId).HasDefaultValueSql("(0)");

                entity.Property(e => e.ISumBillQuantity).HasDefaultValueSql("(0)");

                entity.Property(e => e.ITaxRate).HasDefaultValueSql("(0)");

                entity.Property(e => e.IVmisettleNum).HasDefaultValueSql("(0)");

                entity.Property(e => e.IVmisettleQuantity).HasDefaultValueSql("(0)");

                entity.Property(e => e.Iordertype).HasDefaultValueSql("(0)");

                entity.Property(e => e.Iposflag).HasDefaultValueSql("(0)");

                entity.Property(e => e.Rowufts)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TjgCgdj>(entity =>
            {
                entity.HasKey(e => e.Primaryid)
                    .HasName("PK__tjg_cgdj__77EFAA48CBDC661A");
            });

            modelBuilder.Entity<TjgCgjg>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("tjg_cgjg");
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.HasKey(e => e.CWhCode)
                    .HasName("aaaaaWarehouse_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.CDepCode)
                    .HasName("DepartmentWarehouse");

                entity.HasIndex(e => e.CWhCode)
                    .HasName("Warehouse_cWhCode_Idx");

                entity.HasIndex(e => e.CWhName)
                    .HasName("cWhName");

                entity.HasIndex(e => new { e.CWhCode, e.CWhValueStyle })
                    .HasName("ix_IA_WareHouse_ValueStyle");

                entity.Property(e => e.BBondedWh).HasDefaultValueSql("(0)");

                entity.Property(e => e.BCheckSubitemCost).HasDefaultValueSql("(1)");

                entity.Property(e => e.BControlSerial).HasDefaultValueSql("(1)");

                entity.Property(e => e.BFreeze).HasDefaultValueSql("(0)");

                entity.Property(e => e.BInAvailCalcu).HasDefaultValueSql("(1)");

                entity.Property(e => e.BInCost).HasDefaultValueSql("(1)");

                entity.Property(e => e.BMrp).HasDefaultValueSql("(1)");

                entity.Property(e => e.BProxyWh).HasDefaultValueSql("(0)");

                entity.Property(e => e.BRop).HasDefaultValueSql("(0)");

                entity.Property(e => e.BShop).HasDefaultValueSql("(0)");

                entity.Property(e => e.BWhAsset).HasDefaultValueSql("(0)");

                entity.Property(e => e.IExconMode).HasDefaultValueSql("(0)");

                entity.Property(e => e.ISaconMode).HasDefaultValueSql("(0)");

                entity.Property(e => e.IStconMode).HasDefaultValueSql("(0)");

                entity.Property(e => e.IWhproperty).HasDefaultValueSql("(0)");

                entity.Property(e => e.Pubufts)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.CDepCodeNavigation)
                    .WithMany(p => p.Warehouse)
                    .HasForeignKey(d => d.CDepCode)
                    .HasConstraintName("FK__Warehouse__cDepC__46093FC3");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
