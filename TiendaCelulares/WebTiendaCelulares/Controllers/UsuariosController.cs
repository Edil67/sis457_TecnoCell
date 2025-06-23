using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTiendaCelulares.Models;

namespace WebTiendaCelulares.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly FinalTiendaCelularesContext _context;

        public UsuariosController(FinalTiendaCelularesContext context)
        {
            _context = context;
        }

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            var finalTiendaCelularesContext = _context.Usuarios
                .Include(u => u.IdEmpleadoNavigation);
            return View(await finalTiendaCelularesContext.ToListAsync());
        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .Include(u => u.IdEmpleadoNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            ViewData["IdEmpleado"] = new SelectList(
    _context.Empleados
        .Where(e => e.Estado != -1)
        .Select(e => new { e.Id, NombreCompleto = e.Nombres  }),
    "Id",
    "NombreCompleto"
);

            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEmpleado,nombreUsuario,Clave,UsuarioRegistro,FechaRegistro,Estado")] Usuario usuario)
        {
            var empleadoValido = _context.Empleados.Any(e => e.Id == usuario.IdEmpleado && e.Estado != -1);
            if (!empleadoValido)
            {
                ModelState.AddModelError("IdEmpleado", "El empleado seleccionado no existe o está deshabilitado.");
            }

            if (!ModelState.IsValid)
            {
                usuario.UsuarioRegistro = User.Identity.Name;
                usuario.FechaRegistro = DateTime.Now;
                usuario.Estado = 1;

                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["IdEmpleado"] = new SelectList(
                _context.Empleados.Where(e => e.Estado != -1), "Id", "Nombres", usuario.IdEmpleado);

            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            ViewData["IdEmpleado"] = new SelectList(_context.Empleados, "Id", "Id", usuario.IdEmpleado);
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdEmpleado,nombreUsuario,Clave,UsuarioRegistro,FechaRegistro,Estado")] Usuario usuario)
        {
            if (id != usuario.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    usuario.UsuarioRegistro = User.Identity.Name;
                    usuario.FechaRegistro = DateTime.Now;
                    usuario.Estado = 1;


                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdEmpleado"] = new SelectList(_context.Empleados, "Id", "Id", usuario.IdEmpleado);
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .Include(u => u.IdEmpleadoNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario != null)
            {
                usuario.UsuarioRegistro = User.Identity.Name;
                usuario.FechaRegistro = DateTime.Now;
                usuario.Estado = -1;
                _context.Usuarios.Remove(usuario);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuarios.Any(e => e.Id == id);
        }
    }
}
