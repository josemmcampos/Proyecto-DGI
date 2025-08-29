// Controllers/EmpleadoController.cs

using Microsoft.AspNetCore.Mvc;

namespace TuProyecto.Controllers
{
    public class EmpleadoController : Controller
    {
        // Acción para mostrar la lista de empleados
        public IActionResult Index()
        {
            return View();
        }

        // Puedes agregar más acciones si necesitas CRUD
        // Ejemplo: Create, Edit, Delete, Details
    }
}