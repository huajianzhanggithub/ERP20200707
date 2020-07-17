using ERP20200707.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ERP20200707.Pages.TjgCgjds
{
    public class DeleteModel : PageModel
    {
        private readonly ERP20200707.Data.UFDATA_999_2016Context _context;

        public DeleteModel(ERP20200707.Data.UFDATA_999_2016Context context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TjgCgdj = await _context.TjgCgdj.FindAsync(id);

            if (TjgCgdj != null)
            {
                _context.TjgCgdj.Remove(TjgCgdj);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
