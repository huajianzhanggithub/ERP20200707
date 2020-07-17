using ERP20200707.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ERP20200707.Pages.TjgCgjds
{
    public class EditModel : PageModel
    {
        private readonly ERP20200707.Data.UFDATA_999_2016Context _context;

        public EditModel(ERP20200707.Data.UFDATA_999_2016Context context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TjgCgdj).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TjgCgdjExists(TjgCgdj.Primaryid))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TjgCgdjExists(int id)
        {
            return _context.TjgCgdj.Any(e => e.Primaryid == id);
        }
    }
}
