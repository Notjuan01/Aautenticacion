using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Autenticacion.Pages.Estudiantes
{
    public class EstudiantesModel : PageModel
    {
        [Authorize]
        public void OnGet()
        {
        }
    }
}
