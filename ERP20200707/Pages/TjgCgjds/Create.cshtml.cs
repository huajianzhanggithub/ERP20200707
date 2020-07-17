using ERP20200707.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace ERP20200707.Pages.TjgCgjds
{
    public class CreateModel : PageModel
    {
        private readonly ERP20200707.Data.UFDATA_999_2016Context _context;

        public CreateModel(ERP20200707.Data.UFDATA_999_2016Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TjgCgdj TjgCgdj { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TjgCgdj.Add(TjgCgdj);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
