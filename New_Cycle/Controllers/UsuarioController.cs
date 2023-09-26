using New_Cycle.Models;
using System.Web.Mvc;

public class UsuarioController : Controller
{
    // GET: /Usuario/Registro
    public ActionResult Registro()
    {
        return View();
    }

    // POST: /Usuario/Registro
    [HttpPost]
    public ActionResult Registro(Usuario usuario)
    {
        if (ModelState.IsValid)
        {
            // Validar aquí si las contraseñas coinciden.
            if (usuario.Contraseña != usuario.ConfirmarContraseña)
            {
                ModelState.AddModelError("ConfirmarContraseña", "Las contraseñas no coinciden.");
                return View(usuario);
            }

            // Aquí debes realizar la lógica de registro, como guardar el usuario en la base de datos.
            // Por ejemplo, puedes usar Entity Framework para interactuar con la base de datos.

            // Guardar el usuario en la base de datos (esto es un ejemplo simplificado):
            // dbContext.Usuarios.Add(usuario);
            // dbContext.SaveChanges();

            // Redirigir a la página de inicio de sesión u otra página después del registro.
            return RedirectToAction("InicioSesion", "Autenticacion");
        }

        // Si la validación falla, muestra la vista de registro nuevamente con errores.
        return View(usuario);
    }
}
