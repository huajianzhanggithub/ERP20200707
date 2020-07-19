using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ERP20200707.Data;
using ERP20200707.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace ERP20200707.Pages.TjgCgdjs
{
    public class TjgCgdjsModel : PageModel
    {
        private readonly ERP20200707.Data.UFDATA_999_2016Context _context;

        public TjgCgdjsModel(ERP20200707.Data.UFDATA_999_2016Context context)
        {
            _context = context;
        }

        [DataType(DataType.Date)]
        [Display(Name = "开始日期：")]
        [BindProperty(SupportsGet = true)]
        public DateTime StartDate { get; set; } = DateTime.Parse("2010-01-01");

        [DataType(DataType.Date)]
        [Display(Name = "结束日期：")]
        [BindProperty(SupportsGet = true)]
        public DateTime EndDate { get; set; } = DateTime.Now;

        /// <summary>
        /// 仓库项目
        /// </summary>
        [Display(Name = "仓库：")]
        [BindProperty(SupportsGet = true)]
        public string Warehouse { get; set; }

        public SelectList Warehouses { get; set; }

        /// <summary>
        /// 存货项目
        /// </summary>
        [Display(Name = "存货大类：")]
        [BindProperty(SupportsGet = true)]
        public string InventoryCategory { get; set; }

        /// <summary>
        /// 按仓库编号排序
        /// </summary>
        public string WarehouseSort { get; set; }

        public SelectList InventoryCategorys { get; set; }

        public IList<TjgCgdj> TjgCgdjs { get; set; }
        public void AnotherCreateData(DateTime begin, DateTime end, string inventoryCategory)
        {
            _context.Database.ExecuteSqlInterpolated($"delete from tjg_cgdj");
            _context.Database.ExecuteSqlInterpolated($"insert into tjg_cgdj(autoid, id, cinvcode, iunitcost, iquantity, iprice) select a.autoid, a.id, a.cinvcode, a.iUnitCost, a.iQuantity, a.iprice from rdrecords01 a where a.cInvCode in (select cInvCode from Inventory where   cinvccode like {inventoryCategory}) and a.id >= (select min(id) from  RdRecord01 where dDate >= {begin} and dDate <= {end}) and (a.iUnitCost > (select top 1 iUnitCost from rdrecords01 where AutoID < a.AutoID and cinvcode = a.cinvcode order by id desc))");

            _context.Database.ExecuteSqlInterpolated($"update tjg_cgdj set lautoid = (select top 1 autoid from rdrecords01 where AutoID < tjg_cgdj.autoid and cinvcode=tjg_cgdj.cinvcode order by id desc)");

            _context.Database.ExecuteSqlInterpolated($"update tjg_cgdj  set lid=b.ID,liunitcost=b.iUnitCost from rdrecords01 b where lautoid=b.autoid");

            _context.Database.ExecuteSqlInterpolated($"update tjg_cgdj set whcode=cwhcode,cgrq=dDate from RdRecord01 where RdRecord01.id=tjg_cgdj.id ");
        }
        public async Task OnGetAsync()
        {
            IQueryable<string> warehouseQuery = from a in _context.Warehouse
                                                orderby a.CWhCode + "-" + a.CWhName
                                                select a.CWhCode + "-" + a.CWhName;

            IQueryable<string> inventoryCategoryQuery = from x in _context.InventoryClass
                                                        where x.CInvCcode.Length == 2
                                                        orderby x.CInvCcode + "-" + x.CInvCname
                                                        select x.CInvCcode + "-" + x.CInvCname;

            Warehouses = new SelectList(await warehouseQuery.Distinct().ToListAsync());
            InventoryCategorys = new SelectList(await inventoryCategoryQuery.Distinct().ToListAsync());

            var ic = InventoryCategory == null ? "03" : InventoryCategory.Substring(0, 2);

            this.AnotherCreateData(StartDate, EndDate, ic);

            IQueryable<TjgCgdj> tjgCgdjs = from t in _context.TjgCgdj
                                           select t;

            if (!string.IsNullOrEmpty(Warehouse))
            {
                tjgCgdjs = tjgCgdjs.Where(t => t.Whcode == Warehouse.Substring(0, 3));
            }

            TjgCgdjs = await tjgCgdjs.AsNoTracking().ToListAsync();
        }
    }
}
