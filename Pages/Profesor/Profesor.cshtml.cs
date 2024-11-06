using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Autenticacion.Pages.Profesor
{
    public class ProfesorModel : PageModel
    {
        [Authorize]
        public void OnGet()
        {
        }
    }
}
