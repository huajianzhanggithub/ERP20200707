using ERP20200707.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ERP20200707.Pages.TjgCgjds
{
    public class DetailsModel : PageModel
    {
        private readonly ERP20200707.Data.UFDATA_999_2016Context _context;

        public DetailsModel(ERP20200707.Data.UFDATA_999_2016Context context)
        {
            _context = context;
        }

        public TjgCgdj TjgCgdj { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TjgCgdj = await _context.TjgCgdj.FirstOrDefaultAsync(m => m.Primaryid == id);

            if (TjgCgdj == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
