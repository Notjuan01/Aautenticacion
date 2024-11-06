using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Autenticacion.Pages.Subject
{
    public class SubjectModel : PageModel
    {
        [Authorize]
        public void OnGet()
        {
        }
    }

}
