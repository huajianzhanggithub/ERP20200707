using ERP20200707.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ERP20200707.Pages.TjgCgjds
{
    public class IndexModel : PageModel
    {
        private readonly ERP20200707.Data.UFDATA_999_2016Context _context;

        public IndexModel(ERP20200707.Data.UFDATA_999_2016Context context)
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

        public IList<TjgCgdj> TjgCgdj { get; set; }

        //public void CreateData(string inventoryCategory, DateTime begin, DateTime end)
        //{
        //    var allEntity = from x in _context.TjgCgdj
        //                    select x;
        //    _context.TjgCgdj.RemoveRange(allEntity);

        //    var newTableData = from a in _context.Rdrecords01
        //                       where (
        //                       from i in _context.Inventory
        //                       where i.CInvCcode.Contains(inventoryCategory)
        //                       select i.CInvCode
        //                       ).Contains(a.CInvCode)
        //                       &&
        //                       a.Id >= (
        //                       from r in _context.RdRecord01
        //                       where r.DDate >= begin && r.DDate <= end
        //                       select r
        //                       ).Min(u => u.Id)
        //                       &&
        //                       a.IUnitCost > (
        //                       from rd in _context.Rdrecords01
        //                       where rd.AutoId < a.AutoId && rd.CInvCode == a.CInvCode
        //                       orderby rd.Id descending
        //                       select rd.IUnitCost
        //                       ).Take(1).ToList()[0]
        //                       select new { a.AutoId, a.Id, a.CInvCode, a.IUnitCost, a.IQuantity, a.IPrice };
        //}

        public void AnotherCreateData(DateTime begin, DateTime end, string inventoryCategory="00")
        {
            int result;

            result = _context.Database.ExecuteSqlInterpolated($"delete from tjg_cgdj");
            Console.WriteLine($"delete时{result}行受影响");

            Console.WriteLine($"开始时间是：{StartDate}");
            Console.WriteLine($"结束时间是：{EndDate}");

            //result = _context.Database.ExecuteSqlInterpolated($"insert into tjg_cgdj(autoid, id, cinvcode, iunitcost, iquantity, iprice) select a.autoid, a.id, a.cinvcode, a.iUnitCost, a.iQuantity, a.iprice from rdrecords01 a where a.cInvCode in (select cInvCode from Inventory where   cinvccode like '{InventoryCategory.Substring(0, 2)}%') and a.id >= (select min(id) from  RdRecord01 where dDate >= {StartDate} and dDate <= {EndDate}) and (a.iUnitCost > (select top 1 iUnitCost from rdrecords01 where AutoID < a.AutoID and cinvcode = a.cinvcode order by id desc))");
            var ic = inventoryCategory == null ? "00" : inventoryCategory.Substring(0, 2);
            result = _context.Database.ExecuteSqlInterpolated($"insert into tjg_cgdj(autoid, id, cinvcode, iunitcost, iquantity, iprice) select a.autoid, a.id, a.cinvcode, a.iUnitCost, a.iQuantity, a.iprice from rdrecords01 a where a.cInvCode in (select cInvCode from Inventory where   cinvccode like '{ic}%') and a.id >= (select min(id) from  RdRecord01 where dDate >= {begin} and dDate <= {end}) and (a.iUnitCost > (select top 1 iUnitCost from rdrecords01 where AutoID < a.AutoID and cinvcode = a.cinvcode order by id desc))");

            Console.WriteLine($"insert时{result}行受影响");

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

            this.AnotherCreateData(StartDate, EndDate, InventoryCategory);

            TjgCgdj = await _context.TjgCgdj.ToListAsync();
        }
    }
}
