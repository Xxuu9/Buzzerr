using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buzzerr.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Buzzerr.Context.DataContext _context;

        public IndexModel(Buzzerr.Context.DataContext context)
        {
            _context = context;
        }

        public void OnGet()
        {

        }

        [BindProperty]
        public Models.Student Student { get; set; }


        public async Task<IActionResult> OnPostAsync()

        {
            if (!ModelState.IsValid)

            {
                return Page();

            }
            else {
                _context.Students.Add(Student);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

        }

    }
}
