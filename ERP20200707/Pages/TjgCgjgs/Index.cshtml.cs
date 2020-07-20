using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ERP20200707.Data;
using ERP20200707.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using ClosedXML.Excel;
using System.IO;

namespace ERP20200707.Pages.TjgCgjgs
{
    public class IndexModel : PageModel
    {
        private readonly UFDATA_999_2016Context _context;
        public IndexModel(UFDATA_999_2016Context context)
        {
            _context = context;
        }

        [Display(Name = "仓库：")]
        [BindProperty(SupportsGet = true)]
        public string Warehouse { get; set; }

        public SelectList Warehouses { get; set; }

        public IList<TjgCgjg> TjgCgjgs { get; set; }

        public IActionResult OnGetExcel()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Export.xlsx");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "仓库编码";
                worksheet.Cell(currentRow, 2).Value = "仓库名称";
                worksheet.Cell(currentRow, 3).Value = "入库日期";
                worksheet.Cell(currentRow, 4).Value = "单据编号";
                worksheet.Cell(currentRow, 5).Value = "存货名称";
                worksheet.Cell(currentRow, 6).Value = "规格型号";
                worksheet.Cell(currentRow, 7).Value = "数量";
                worksheet.Cell(currentRow, 8).Value = "单价";
                worksheet.Cell(currentRow, 9).Value = "价格";
                worksheet.Cell(currentRow, 10).Value = "上次购买单据编号";
                worksheet.Cell(currentRow, 11).Value = "上次购买单价";
                worksheet.Cell(currentRow, 12).Value = "差额";
                worksheet.Cell(currentRow, 13).Value = "百分比";

                IQueryable<TjgCgjg> tjgCgjgs;

                if (!string.IsNullOrEmpty(Warehouse))
                {
                    tjgCgjgs = from t in _context.TjgCgjg
                               where t.Whcode == Warehouse.Substring(0, 3)
                               select t;
                }
                else
                {
                    tjgCgjgs = from t in _context.TjgCgjg
                               select t;
                }

                foreach (var item in tjgCgjgs)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = item.Whcode;
                    worksheet.Cell(currentRow, 2).Value = item.CWhName;
                    var rkrq = item.Cgrq.Value.ToString("yyyy-MM-dd");
                    worksheet.Cell(currentRow, 3).Value = rkrq;
                    worksheet.Cell(currentRow, 4).Value = item.Ccode;
                    worksheet.Cell(currentRow, 5).Value = item.CInvName;
                    worksheet.Cell(currentRow, 6).Value = item.CInvStd;
                    worksheet.Cell(currentRow, 7).Value = item.Iquantity;
                    worksheet.Cell(currentRow, 8).Value = item.Iunitcost;
                    worksheet.Cell(currentRow, 9).Value = item.Iprice;
                    worksheet.Cell(currentRow, 10).Value = item.Lccode;
                    worksheet.Cell(currentRow, 11).Value = item.Liunitcost;
                    decimal difference = (decimal)((item.Iunitcost - item.Liunitcost) * item.Iquantity);
                    worksheet.Cell(currentRow, 12).Value = difference;
                    var bfb = ((item.Iunitcost - item.Liunitcost) / item.Iunitcost).Value.ToString("P");
                    worksheet.Cell(currentRow, 13).Value = bfb;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(
                        content,
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "Export.xlsx");
                }
            }
        }
        public async Task OnGetAsync()
        {
            IQueryable<string> warehouseQuery = from a in _context.Warehouse
                                                orderby a.CWhCode + "-" + a.CWhName
                                                select a.CWhCode + "-" + a.CWhName;
            Warehouses = new SelectList(await warehouseQuery.Distinct().ToListAsync());
            IQueryable<TjgCgjg> tjgCgjgs = from t in _context.TjgCgjg
                                           select t;

            if (!string.IsNullOrEmpty(Warehouse))
            {
                tjgCgjgs = tjgCgjgs.Where(t => t.Whcode == Warehouse.Substring(0, 3));
            }

            TjgCgjgs = await tjgCgjgs.AsNoTracking().ToListAsync();
        }
    }
}