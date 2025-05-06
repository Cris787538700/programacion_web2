using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppFerreteria.Models;
using WebAppFerreteria.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

public class AuthController : Controller
{
    private readonly FerreteriaDbContext _context;

    public AuthController(FerreteriaDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View(new LoginViewModel());
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var user = await _context.Usuarios
            .FirstOrDefaultAsync(u => u.NombreUsuario == model.NombreUsuario && u.Contrasena == model.Contrasena);

        if (user == null)
        {
            ModelState.AddModelError("", "Credenciales inválidas");
            return View(model);
        }

        // ✅ Verificar si el usuario está bloqueado
        if (user.EstaBloqueado)
        {
            ModelState.AddModelError("", "Este usuario está bloqueado. Contacte al administrador.");
            return View(model);
        }

        // Guardar datos en sesión
        HttpContext.Session.SetString("Usuario", user.NombreUsuario);
        HttpContext.Session.SetString("Rol", user.Rol);

        return RedirectToAction("Index", "Home");
    }

    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Login");
    }
}
