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
        public IActionResult Excel(IList<string> datas)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Export.xlsx");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Id";
                worksheet.Cell(currentRow, 2).Value = "Username";
                foreach (var user in datas)
                {
                    currentRow++;
                    //worksheet.Cell(currentRow, 1).Value = user.Id;
                    //worksheet.Cell(currentRow, 2).Value = user.Username;
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